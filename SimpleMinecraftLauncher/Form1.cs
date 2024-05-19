using MinecraftLaunch.Classes.Models.Game;
using MinecraftLaunch.Components.Authenticator;
using MinecraftLaunch.Components.Launcher;
using MinecraftLaunch.Components.Resolver;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using MinecraftLaunch.Components.Fetcher;
using MinecraftLaunch.Components.Installer;
using Newtonsoft.Json.Linq;
using System.Net;
using Microsoft.VisualBasic.FileIO;
using MinecraftLaunch.Classes.Models.Download;
using MinecraftLaunch;
using System.IO.Compression;
using MinecraftLaunch.Utilities;
using System.Text.Json.Nodes;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.ConstrainedExecution;
using MinecraftLaunch.Classes.Models.Launch;
using StarLight_Core.Models.Launch;
using LaunchConfig = StarLight_Core.Models.Launch.LaunchConfig;
using StarLight_Core.Models.Authentication;
using StarLight_Core.Enum;
using GameWindowConfig = StarLight_Core.Models.Launch.GameWindowConfig;
using StarLight_Core.Authentication;
using StarLight_Core.Launch;

namespace SimpleMinecraftLauncher
{
    public partial class Form1 : Form
    {
        int SidebarWidth = 160;
        public List<string> JavaPathList = [];
        public List<string> OfflineUsers = [];
        List<string> versions = [];
        int Tasks = -1;
        List<string> UsersUuidList = [];
        List<string> GamePathNameList = [];
        List<(string path, string Name)> GamePathList = [];
        System.Collections.Immutable.ImmutableArray<JavaEntry> JavaList;
        string gamepath = ".minecraft";
        GameResolver resolver = new();
        int Maxmem;
        public async Task LaunchMC()
        {
            OptimizationTimer.Stop();
            string log4j2ConfigInJVMArgs = "";
            if (!Directory.Exists($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives"))
            {
                Directory.CreateDirectory($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives");
            }
            string jsonpath = $"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\{VersionsComboBox.SelectedItem}.json";
            string cp = "";
            string gameArgs = "";
            string mainClass = "";
            string assindex = "";
            JObject jsonObject = JObject.Parse(File.ReadAllText(jsonpath));

            try
            {
                mainClass = jsonObject["mainClass"].ToString();
                assindex = jsonObject["assetIndex"]["id"].ToString();
            }
            catch { }

            JArray jArray = (JArray)jsonObject["libraries"];
            try
            {
                string assetsIndexUrl = jsonObject["assetIndex"]["url"].ToString();
                string assetsIndexId = jsonObject["assetIndex"]["id"].ToString() + ".json";
                if (!File.Exists($"{gamepath}\\assets\\indexes\\{assetsIndexId}"))
                {
                    AutoCreateDirectory($"{gamepath}\\assets\\indexes");
                    await DownloadFileAsync(assetsIndexUrl, $"{gamepath}\\assets\\indexes\\{assetsIndexId}");
                }
                JObject jobj = JObject.Parse(File.ReadAllText($"{gamepath}\\assets\\indexes\\{assetsIndexId}"));
                JToken objs = jobj["objects"];


                foreach (var item in objs)
                {
                    var hash = item.First["hash"];
                    var hh = hash.ToString();
                    string dir = hh.Substring(0, 2);
                    if (!File.Exists($"{gamepath}\\assets\\objects\\{dir}\\{hash}"))
                    {
                        AutoCreateDirectory($"{gamepath}\\assets\\objects\\{dir}");
                        await DownloadFileAsync($"https://resources.download.minecraft.net/{dir}/{hash}", $"{gamepath}\\assets\\objects\\{dir}\\{hash}");
                    }
                    else if (new FileInfo($"{gamepath}\\assets\\objects\\{dir}\\{hash}").Length != (long)item.First["size"])
                    {
                        File.Delete($"{gamepath}\\assets\\objects\\{dir}\\{hash}");
                        await DownloadFileAsync($"https://resources.download.minecraft.net/{dir}/{hash}", $"{gamepath}\\assets\\objects\\{dir}\\{hash}");
                    }
                }
            }
            catch 
            { }
            try
            {
                gameArgs = jsonObject["minecraftArguments"].ToString();
                gameArgs = gameArgs.Replace("${auth_player_name}", UsersComboBox.SelectedItem.ToString());
                gameArgs = gameArgs.Replace("${version_name}", VersionsComboBox.SelectedItem.ToString());
                gameArgs = gameArgs.Replace("${game_directory}", gamepath);
                gameArgs = gameArgs.Replace("${assets_root}", gamepath + "\\assets");
                gameArgs = gameArgs.Replace("${assets_index_name}", assindex);
                gameArgs = gameArgs.Replace("${auth_uuid}", UsersUuidList[UsersComboBox.SelectedIndex].ToString());
                gameArgs = gameArgs.Replace("${auth_access_token}", Guid.NewGuid().ToString("N"));
                gameArgs = gameArgs.Replace("${user_type}", "mojang");
                gameArgs = gameArgs.Replace("${version_type}", "\"Simple Minecraft Launcher\"");
                gameArgs = gameArgs.Replace("${clientid}", VersionsComboBox.SelectedItem.ToString());
                gameArgs = gameArgs.Replace("${auth_xuid}", Guid.NewGuid().ToString("N"));
                gameArgs = gameArgs.Replace("${user_properties}", $"{gamepath}\\usercache.json");
                gameArgs = gameArgs.Replace("${auth_session}", UsersUuidList[UsersComboBox.SelectedIndex]);
                gameArgs = gameArgs.Replace("${game_assets}", $"{gamepath}\\assets");
            }
            catch
            { }
            try
            {
                JArray args_jarray = (JArray)jsonObject["arguments"]["game"];
                args_jarray.Remove(args_jarray.Last);
                args_jarray.Remove(args_jarray.Last);
                args_jarray.Remove(args_jarray.Last);
                args_jarray.Remove(args_jarray.Last);
                args_jarray.Remove(args_jarray.Last);
                args_jarray.Remove(args_jarray.Last);
                foreach (var item in args_jarray)
                {
                    gameArgs += $" {item}";
                }
                gameArgs = gameArgs.Replace("${auth_player_name}", UsersComboBox.SelectedItem.ToString());
                gameArgs = gameArgs.Replace("${version_name}", VersionsComboBox.SelectedItem.ToString());
                gameArgs = gameArgs.Replace("${game_directory}", gamepath);
                gameArgs = gameArgs.Replace("${assets_root}", gamepath + "\\assets");
                gameArgs = gameArgs.Replace("${game_assets}", gamepath + "\\assets");
                gameArgs = gameArgs.Replace("${assets_index_name}", assindex);
                gameArgs = gameArgs.Replace("${auth_uuid}", UsersUuidList[UsersComboBox.SelectedIndex].ToString());
                gameArgs = gameArgs.Replace("${auth_access_token}", Guid.NewGuid().ToString("N"));
                gameArgs = gameArgs.Replace("${user_type}", "mojang");
                gameArgs = gameArgs.Replace("${version_type}", "\"Simple Minecraft Launcher\"");
                gameArgs = gameArgs.Replace("${clientid}", VersionsComboBox.SelectedItem.ToString());
                gameArgs = gameArgs.Replace("${auth_xuid}", Guid.NewGuid().ToString("N"));
            }
            catch { }//gameArgs
            if (!Directory.Exists($"{gamepath}\\libraries")) { Directory.CreateDirectory($"{gamepath}\\libraries"); }
            try
            {
                string log4j2XMLUrl = jsonObject["logging"]["client"]["file"]["url"].ToString();
                string log4j2Config_arg = jsonObject["logging"]["client"]["argument"].ToString();
                if (!File.Exists($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\log4j2.xml"))
                {
                    DownloadFileAsync(log4j2XMLUrl, $"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\log4j2.xml");
                }
                log4j2ConfigInJVMArgs = $" {log4j2Config_arg.Replace("${path}", "")}{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\log4j2.xml ";
            }
            catch { }
            try
            {
                string MCJarURL = jsonObject["downloads"]["client"]["url"].ToString();
                if (!File.Exists($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\{VersionsComboBox.SelectedItem}.jar"))
                {
                    DownloadFileAsync(MCJarURL, $"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\{VersionsComboBox.SelectedItem}.jar");
                }
            }
            catch { }
            foreach (var item in jArray)
            {
                try
                {
                    try
                    {
                        string save_artifact = $"{gamepath}\\libraries\\{item["downloads"]["artifact"]["path"]}";
                        string url_artifact = item["downloads"]["artifact"]["url"].ToString();
                        if (!File.Exists(save_artifact))
                        {
                            var tmp = save_artifact;
                            int lastIndex = save_artifact.LastIndexOf('/');
                            if (lastIndex != -1)
                            {
                                save_artifact = save_artifact.Substring(0, lastIndex);
                            }
                            AutoCreateDirectory(save_artifact);
                            await DownloadFileAsync(url_artifact.ToString(), tmp);
                        }
                        cp += $"{save_artifact};";
                    }
                    catch
                    {
                        string name = item["name"].ToString();
                        int firstColonIndex = name.IndexOf(":"); // 获取第一个冒号的位置
                        int firstdotIndex = name.IndexOf(".");
                        if (firstColonIndex >= 0&& firstColonIndex >= 0)
                        {
                            string path = name.Remove(firstColonIndex, 1).Insert(firstColonIndex, "\\"); 
                            path = path.Remove(firstdotIndex, 1).Insert(firstdotIndex, "\\");
                            int lastColonIndex = name.LastIndexOf(':');
                            string lastPart = name.Substring(lastColonIndex + 1);
                            path = path.Replace(":", "\\");
                            path = $"{gamepath}\\libraries\\{path}\\{lastPart}.jar;";
                            cp += path;
                        }
                        
                    }
                }
                catch 
                {}
            }
            foreach (var item in jArray)
            {
                try
                {
                    string save = $"{gamepath}\\libraries\\{item["downloads"]["classifiers"]["natives-windows"]["path"]}";
                    string url = item["downloads"]["classifiers"]["natives-windows"]["url"].ToString();
                    if (!File.Exists(save))
                    {
                        var tmp = save;
                        int lastIndex = save.LastIndexOf('\\');
                        if (lastIndex != -1)
                        {
                            save = save.Substring(0, lastIndex);
                        }
                        await DownloadFileAsync(url.ToString(), tmp);
                    }
                    if (!Directory.Exists($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives")) { Directory.CreateDirectory($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives"); }
                    ZipFile.ExtractToDirectory(save, $"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives");
                    cp += $"{save};";
                    if (Directory.Exists($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\\META-INF")) { Directory.Delete($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\\META-INF", true); }
                }
                catch
                {}
            }
            if (Directory.Exists($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\\META-INF")) { Directory.Delete($"{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\\META-INF", true); }
            // JSON文件路径
            string launchCommand = $"-Xmx{Maxmem}M -XX:+AggressiveOpts -XX:+UseConcMarkSweepGC -XX:+UseParNewGC -XX:+CMSConcurrentMTEnabled -XX:ParallelGCThreads=8 -Dsun.rmi.dgc.server.gcInterval=3600000 -XX:+UnlockExperimentalVMOptions " +
                $"-XX:+ExplicitGCInvokesConcurrent -XX:MaxGCPauseMillis=50 " +
                $"-XX:+AlwaysPreTouch -XX:+UseStringDeduplication -Dfml.ignorePatchDiscrepancies=true -Dfml.ignoreInvalidMinecraftCertificates=true -XX:-OmitStackTraceInFastThrow -XX:+OptimizeStringConcat -XX:+UseAdaptiveGCBoundary" +
                $" -XX:NewRatio=3 -Dfml.readTimeout=90 -XX:+UseFastAccessorMethods -Xmx32560m -Dfile.encoding=GB18030 " +
                $"-Dsun.stdout.encoding=GB18030 -Dsun.stderr.encoding=GB18030 -Djava.rmi.server.useCodebaseOnly=true -Dcom.sun.jndi.rmi.object.trustURLCodebase=false" +
                $" -Dcom.sun.jndi.cosnaming.object.trustURLCodebase=false -Dlog4j2.formatMsgNoLookups=true" +
                $"-XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump " +
                $"\"-Djna.tmpdir={gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\" \"-Dorg.lwjgl.system.SharedLibraryExtractPath={gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\" \"-Dio.netty.native.workdir={gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\"" +
                $" {log4j2ConfigInJVMArgs} " +
                $"-Xss1M  \"-Djava.library.path={gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\natives\" " +
                $"\"-Dminecraft.launcher.brand=Simple Minecraft Launcher\" -Dminecraft.launcher.version=0.0.0000 " +
                $"-cp \"{cp}{gamepath}\\versions\\{VersionsComboBox.SelectedItem}\\{VersionsComboBox.SelectedItem}.jar\" " +
                $" {mainClass} {gameArgs}";
            // 创建一个ProcessStartInfo实例
            /*ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = JavaPathComboBox.SelectedItem.ToString(), // PowerShell的可执行文件
                Arguments = launchCommand, // 设置执行策略和脚本文件路径
                RedirectStandardOutput = true, // 重定向标准输出
                UseShellExecute = false, // 不使用Shell启动
                CreateNoWindow = true // 不创建新窗口
            };

            // 使用ProcessStartInfo启动PowerShell脚本
            using (Process process = new())
            {
                process.StartInfo = startInfo;
                process.Start(); // 启动进程
                string output = process.StandardOutput.ReadToEnd(); // 读取输出
                Console.WriteLine(output);
            }*/
            Process.Start(JavaPathComboBox.SelectedItem.ToString(), launchCommand);
            OptimizationTimer.Start();
        }
        public async Task<bool> DownloadFileAsync(string fileUrl, string localPath)
        {
            try
            {
                // 确保本地路径的目录存在
                var directory = Path.GetDirectoryName(localPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // 发起请求并等待结果
                using var response = await new HttpClient().GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead);
                if (!response.IsSuccessStatusCode)
                {
                    // 如果响应状态码不是成功的，返回false
                    return false;
                }

                // 将响应内容写入本地文件
                using var fileStream = new FileStream(localPath, FileMode.Create, FileAccess.Write, FileShare.None);
                using var stream = await response.Content.ReadAsStreamAsync();
                await stream.CopyToAsync(fileStream);

                return true;
            }
            catch
            {
                // 如果在下载过程中发生异常，返回false
                return false;
            }
        }
        public void AutoCreateDirectory(string path)
        {
            string parentDirectory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(parentDirectory))
            {
                AutoCreateDirectory(parentDirectory);
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        // 将 List 写入到文本文件
        static void WriteListToTextFile(List<string> list, string filePath)
        {
            try
            {
                using (StreamWriter writer = new(filePath))
                {
                    foreach (string item in list)
                    {
                        writer.WriteLine(item);
                    }
                }
                Console.WriteLine($"成功将 List 写入到 {filePath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"写入 {filePath} 时出错：{e.Message}");
            }
        }
        static void WriteList_strstr_ToFile(List<(string, string)> list, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var (key, value) in list)
                    {
                        writer.WriteLine($"{key},{value}");
                    }
                }
                Console.WriteLine($"成功将 List 写入到 {filePath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"写入 {filePath} 时出错：{e.Message}");
            }
        }

        // 从文本文件中读取 List
        static List<string> ReadTextFileToList(string fileName)
        {
            List<string> list = [];
            try
            {
                using (StreamReader reader = new(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"读取 {fileName} 时出错：{e.Message}");
            }
            return list;
        }
        static List<(string, string)> ReadList_strstr_FromFile(string filePath)
        {
            List<(string, string)> list = [];
            try
            {
                using StreamReader reader = new(filePath);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        list.Add((parts[0], parts[1]));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"读取 {filePath} 时出错：{e.Message}");
            }

            return list;
        }
        public string INIPath = Convert.ToString(AppDomain.CurrentDomain.BaseDirectory) + "SMCL_data/SMCL_config.txt";
        // 声明INI文件的写操作函数 WritePrivateProfileString()

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        // 写入INI的方法
        public void INIWrite(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, INIPath);
        }
        // 读取INI的方法
        public string INIRead(string section, string key)
        {
            StringBuilder temp = new(255);
            GetPrivateProfileString(section, key, "", temp, 255, INIPath);
            return temp.ToString();
        }
        public void javapath_upd(ComboBox comboBox, List<string> List)
        {
            List = ReadTextFileToList("SMCL_data/JavaPathList.txt");
            comboBox.Items.Clear();
            comboBox.Items.AddRange(List.ToArray());
            WriteListToTextFile(List, "SMCL_data/JavaPathList.txt");
        }
        public void OfflineUsers_upd(ReaLTaiizor.Controls.MetroListBox listBox, List<string> List)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(List.ToArray());
            WriteListToTextFile(List, "SMCL_data/OfflineUsersList.txt");
        }
        public async Task FindJava()
        {
            //实例化
            JavaFetcher javaFetcher = new();

            //搜索磁盘里的Java并把它们存储到一个集合里
            JavaList = await javaFetcher.FetchAsync();

            //输出
            Debug.WriteLine("你的设备总共有" + JavaList.Length + "个Java，它们是：");

            JavaPathList.Clear();
            //遍历集合
            foreach (JavaEntry javalist in JavaList)
            {
                JavaPathList.Add(javalist.JavaPath.ToString());
                //输出Java的信息
                Console.WriteLine("Java路径：" + javalist.JavaPath + "，Java版本：" + javalist.JavaVersion + "，是否为64位：" + javalist.Is64Bit);
            }
            { JavaPathComboBox.Items.Clear(); JavaPathComboBox.Items.AddRange(JavaPathList.ToArray()); JavaPathComboBox.SelectedIndex = JavaPathComboBox.Items.Count - 1; }
        }
        public Form1()
        {
            InitializeComponent();
            OptimizationTimer.Start();
        }
        public async Task DownloadVanilla(string ver, MirrorDownloadSource mirrorDownloadSource)
        {
            OptimizationTimer.Stop();
            Tasks += 1;
            int thisTask = Tasks;
            TasksListBox.AddItem(ver);
            RefreshGamePathButton.Enabled = false;
            var resolver = new GameResolver(gamepath);
            var vanlliaInstaller = new VanlliaInstaller(resolver, ver, mirrorDownloadSource);

            vanlliaInstaller.ProgressChanged += (_, x) =>
            {
                TasksListBox.Items[thisTask] = $"{ver}   {x.ProgressStatus}   {(int)(x.Progress * 100)}%";
            };
            var result = await vanlliaInstaller.InstallAsync();

            if (result)
            {
                Console.WriteLine($"游戏核心 {ver} 安装成功");
                TasksListBox.RemoveItemAt(thisTask);
                Tasks -= 1;
                RefreshGamePathButton.Enabled = true;
                OptimizationTimer.Start();
                FindVersions();
                VersionsListBox.Clear(); VersionsListBox.Items.AddRange(versions);
                VersionsComboBox.Items.Clear(); VersionsComboBox.Items.AddRange(versions.ToArray());
                VersionsComboBox.SelectedText = INIRead("Data", "VersionsComboboxSelectedItem");
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        static List<string> GetMC(string VersionType)
        {
            string url = "https://piston-meta.mojang.com/mc/game/version_manifest.json";
            List<string> officialVersions = new List<string>();

            using (WebClient client = new())
            {
                string json = client.DownloadString(url);
                JObject jsonObject = JObject.Parse(json);
                JArray versions = (JArray)jsonObject["versions"];

                foreach (JObject version in versions)
                {
                    string id = (string)version["id"];
                    string type = (string)version["type"];
                    if (type == VersionType)
                    {
                        officialVersions.Add(id);
                    }
                }
            }
            return officialVersions;
        }
        public void FindVersions()
        {
            if (Directory.Exists(gamepath))
            {
                string[] versionspath;
                versions.Clear();
                versionspath = Directory.GetDirectories(gamepath + @"/versions");
                foreach (var item in versionspath)
                {
                    versions.Add(Path.GetFileName(item));
                }
            }
        }
        public async Task<int> LaunchMCAsync(string username, string gameFolder, string javaPath, string launchCore)
        {
            string uuid = UsersUuidList[UsersComboBox.SelectedIndex];
            var account = new OfflineAuthenticator(username, new Guid(uuid)).Authenticate();
            resolver = new GameResolver(gameFolder);

            var config = new MinecraftLaunch.Classes.Models.Launch.LaunchConfig
            {
                Account = account,
                IsEnableIndependencyCore = true,
                JvmConfig = new(javaPath)
                {
                    MaxMemory = Maxmem,
                },
                LauncherName = "Simple Minecraft Launcher",
            };
            Launcher launcher = new(resolver, config);
            var gameProcessWatcher = await launcher.LaunchAsync(launchCore);

            //获取输出日志
            gameProcessWatcher.OutputLogReceived += (sender, args) =>
            {
                Console.WriteLine(args.Log);
            };

            //检测游戏退出
            gameProcessWatcher.Exited += (sender, args) =>
            {
                Console.WriteLine("exit");
            };
            Console.Write(gameProcessWatcher.Process.Id);
            return gameProcessWatcher.Process.Id;
        }
        static void ReportProgress(ProgressReport report)
        {
            Console.WriteLine($"{report.Description} {report.Percentage}%");
        }
        public async Task LaunchMC_SL()
        {
            LaunchConfig args = new()
            {
                GameWindowConfig = new GameWindowConfig()
                {
                    Height = 480,
                    Width = 854,
                },
                Account = new()
                {
                    BaseAccount = new OfflineAuthentication(UsersComboBox.SelectedItem.ToString(), UsersUuidList[UsersComboBox.SelectedIndex]).OfflineAuth(),
                },
                GameCoreConfig = new GameCoreConfig()
                {
                    Root = gamepath,
                    Version = VersionsComboBox.SelectedItem.ToString(),
                    IsVersionIsolation = true,
                },
                JavaConfig = new JavaConfig()
                {
                    JavaPath = JavaPathComboBox.SelectedItem.ToString(),
                    MaxMemory = Maxmem,
                }
            };
            var Launch=new MinecraftLauncher(args);
            var la=await Launch.LaunchAsync(ReportProgress);
            if (la.Status == Status.Succeeded) { Console.WriteLine(la.ProcessInfo.Pid); }
            if(la.Status == Status.Failed) { Console.WriteLine(la.Exception);}

        }
        private async void LaunchButton_Click(object sender, EventArgs e)
        {
            OptimizationTimer.Stop();
            Tasks += 1;
            int thisTask = Tasks;
            TasksListBox.AddItem($"游戏{VersionsComboBox.SelectedItem}运行中");
            Enabled =false;
            //LaunchMC_SL();
            await LaunchMCAsync((string)UsersComboBox.SelectedItem, gamepath, (string)JavaPathComboBox.SelectedItem, (string)VersionsComboBox.SelectedItem);
            Enabled = true;
            //LaunchMC();
            TasksListBox.RemoveItemAt(thisTask);
            Tasks -= 1;
            OptimizationTimer.Start();
        }

        private void VersionConfig_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = SettingsTabPage;
        }
        private void BrowseJavaPathButton_Click(object sender, EventArgs e)
        {
            JavaPathDialog.ShowDialog();
        }

        private void JavaPathDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AddJavaPathTextBox.Text = JavaPathDialog.FileName;
        }

        private void AddJavaPathButton_Click(object sender, EventArgs e)
        {
            if (AddJavaPathTextBox.Text != "")
            {
                JavaPathList.Add(AddJavaPathTextBox.Text);
                WriteListToTextFile(JavaPathList, "SMCL_data/JavaPathList.txt");
                javapath_upd(JavaPathComboBox, JavaPathList);
                JavaPathComboBox.SelectedIndex = JavaPathComboBox.Items.Count - 1;
            }
            string javapath = AddJavaPathTextBox.Text;
            int repeat = 0;
            foreach (string str in JavaPathComboBox.Items)
            {
                if (javapath == str) { repeat += 1; };
                if (repeat > 1)
                {
                    JavaPathList.Remove(javapath);
                    WriteListToTextFile(JavaPathList, "SMCL_data/JavapathList.txt");
                    JavaPathComboBox.Items.Clear();
                    JavaPathComboBox.Items.AddRange(JavaPathList.ToArray());
                    JavaPathComboBox.SelectedIndex = JavaPathComboBox.Items.Count - 1;
                }
            }
        }
        private void AdduserButton_Click(object sender, EventArgs e)
        {
            AdduserForm form = new();
            DialogResult rc = form.ShowDialog();
            if (rc == DialogResult.OK)
            {
                string uuid = form.UUIDTextBox.Text;
                string username = form.UsernameTextBox.Text;
                OfflineUsers.Add(username);
                WriteListToTextFile(OfflineUsers, "SMCL_data/OfflineUsersList.txt");
                OfflineUsers_upd(UsersListBox, OfflineUsers);
                OfflineUsers = ReadTextFileToList("SMCL_data/OfflineUsersList.txt");
                int repeat = 0;
                foreach (string str in UsersListBox.Items)
                {
                    if (username == str.ToString()) { repeat += 1; }
                    if (repeat > 1) { OfflineUsers.Remove(str); WriteListToTextFile(OfflineUsers, "SMCL_data/OfflineUsersList.txt"); }
                }
                if (form.UUIDTextBox.Text != "")
                {
                    UsersUuidList.Add(uuid);
                    WriteListToTextFile(UsersUuidList, "SMCL_data/UsersUuidList.txt");
                }
                else
                {
                    UsersUuidList.Add(Guid.NewGuid().ToString(format: "N"));
                    WriteListToTextFile(UsersUuidList, "SMCL_data/UsersUuidList.txt");
                }
                UsersListBox.Items.Clear();
                UsersListBox.Items.AddRange(OfflineUsers.ToArray());
                OfflineUsers = ReadTextFileToList("SMCL_data/OfflineUsersList.txt");
                UsersComboBox.Items.Clear();
                UsersComboBox.Items.AddRange(OfflineUsers.ToArray());
                WriteListToTextFile(OfflineUsers, "SMCL_data/OfflineUsersList.txt");
                UsersComboBox.SelectedIndex = UsersComboBox.Items.Count - 1;
            }
        }
        private void DelUserButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedItem != null)
            {
                OfflineUsers.Remove(UsersListBox.SelectedText);
                UsersUuidList.RemoveAt(UsersListBox.SelectedIndex);
                WriteListToTextFile(OfflineUsers, "SMCL_data/OfflineUsersList.txt");
                WriteListToTextFile(UsersUuidList, "SMCL_data/UsersUuidList.txt");
                OfflineUsers_upd(UsersListBox, OfflineUsers);
            }
        }

        private void DelJavaPathButton_Click(object sender, EventArgs e)
        {
            if (JavaPathComboBox.SelectedItem != null)
            {
                JavaPathList.Remove(JavaPathComboBox.SelectedItem.ToString());
                WriteListToTextFile(JavaPathList, "SMCL_data/JavaPathList.txt");
                JavaPathComboBox.Items.Clear();
                JavaPathComboBox.Items.AddRange(JavaPathList.ToArray());
                JavaPathComboBox.SelectedIndex = JavaPathComboBox.Items.Count - 1;
            }
        }

        private void GameMemTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (Text != "")
            {
                string MaxmemText = GameMemTextBox.Text;
                if (int.TryParse(MaxmemText, out Maxmem))
                {
                    Console.WriteLine("使用 int.TryParse() 转换: " + Maxmem);
                }
                else
                {
                    Console.WriteLine("转换失败");
                }
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                INIWrite("GlobalGameSettings", "MaxMem", Maxmem.ToString());
            }
        }
        private void JavaPathComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            INIWrite("GlobalGameSettings", "JavaComboboxSelectedItem", JavaPathComboBox.SelectedItem.ToString());
            string is64bit;
            if (JavaUtil.GetJavaInfo(JavaPathComboBox.SelectedItem.ToString()).Is64Bit)
            {
                is64bit = "64位";
            }
            else { is64bit = "32位"; }
            string JavaVersion = JavaUtil.GetJavaInfo(JavaPathComboBox.SelectedItem.ToString()).JavaVersion;
            JavaInfoLabel.Text = $"Java版本：{JavaVersion} {is64bit}";
        }
        private void UsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            INIWrite("Data", "UsersComboboxSelectedItem", UsersComboBox.SelectedItem.ToString());
        }

        private void VersionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            INIWrite("Data", "VersionsComboboxSelectedItem", VersionsComboBox.SelectedItem.ToString());
        }

        private void FindJavaButton_Click(object sender, EventArgs e)
        {
            FindJava();
            { WriteListToTextFile(JavaPathList, "SMCL_data/JavaPathList.txt"); }
        }
        public void GamePathNameList_upd()
        {
            GamePathNameList.Clear();
            foreach (var item in GamePathList)
            {
                GamePathNameList.Add(item.Name);
            }
            GamePathListBox.Items.Clear(); GamePathListBox.AddItems(GamePathNameList.ToArray());
        }
        private void AddGamePathButton_Click(object sender, EventArgs e)
        {
            AddGamePathForm form = new AddGamePathForm();
            DialogResult dialog = form.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                string pathName = form.GamePathNameTextBox.Text;
                string Path = form.AddGamePathTextBox.Text;
                GamePathList.Add((path: Path, Name: pathName));
                GamePathNameList_upd();
                WriteList_strstr_ToFile(GamePathList, "SMCL_data/GamePathList.txt");
            }
        }

        private void DelGameDirButton_Click(object sender, EventArgs e)
        {
            if (GamePathListBox.SelectedIndex > -1)
            {
                GamePathList.RemoveAt(GamePathListBox.SelectedIndex);
                GamePathNameList_upd();
                WriteList_strstr_ToFile(GamePathList, "SMCL_data/GamePathList.txt");
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            AddGamePathButton.Size = new Size(splitContainer1.SplitterDistance / 3, 30);
            DelGamePathButton.Size = AddGamePathButton.Size;
            OpenGameFolderButton.Size = AddGamePathButton.Size;
            DelGamePathButton.Location = new Point(splitContainer1.SplitterDistance / 3, 0);
            OpenGameFolderButton.Location = new Point((splitContainer1.SplitterDistance / 3) * 2, 0);
            if (splitContainer1.SplitterDistance % 3 != 0) { splitContainer1.SplitterDistance -= splitContainer1.SplitterDistance % 3; }
        }

        private void GamePathListBox_SelectedIndexChanged(object sender)
        {
            gamepath = GamePathList[GamePathListBox.SelectedIndex].path;
            Console.Write(gamepath);
            FindVersions();
            { VersionsListBox.Clear(); VersionsListBox.Items.AddRange(versions); }
            { VersionsComboBox.Items.Clear(); VersionsComboBox.Items.AddRange(versions.ToArray()); }
            if (VersionsComboBox.Items.Count > 0) { VersionsComboBox.SelectedIndex = 0; }
            else { VersionsComboBox.Text = ""; }
            INIWrite("Data", "SelectedGamePathIndex", GamePathListBox.SelectedIndex.ToString());
        }

        private void SidebarWeightTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (Text != "")
            {
                string SidebarWidthText = SidebarWeightTextBox.Text;
                if (int.TryParse(SidebarWidthText, out SidebarWidth))
                {
                    Console.WriteLine("使用 int.TryParse() 转换: " + SidebarWidth);
                }
                else
                {
                    Console.WriteLine("转换失败");
                }
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (SidebarWidth < new Form1().Size.Width - 64 && SidebarWidth >= 40)
                    { TabControl.ItemSize = new(40, SidebarWidth - 1); }
                    else if (SidebarWidth < 40) { SidebarWidth = 40; TabControl.ItemSize = new(40, SidebarWidth - 1); SidebarWeightTextBox.Text = SidebarWidth.ToString(); }
                    else if (SidebarWidth > new Form1().Size.Width - 64) { SidebarWidth = 160; TabControl.ItemSize = new(40, SidebarWidth - 1); SidebarWeightTextBox.Text = SidebarWidth.ToString(); }
                    INIWrite("AppearanceSettings", "SidebarWidth", SidebarWidth.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindVersions();
            VersionsListBox.Clear(); VersionsListBox.Items.AddRange(versions);
            VersionsComboBox.Items.Clear(); VersionsComboBox.Items.AddRange(versions.ToArray());
            VersionsComboBox.SelectedText = INIRead("Data", "VersionsComboboxSelectedItem");
        }

        private void OpenGameFolderButton_Click(object sender, EventArgs e)
        {
            string path = GamePathList[GamePathListBox.SelectedIndex].path;
            Process.Start("explorer", path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TabControl.SelectedTab = LaunchTabPage;
            OfflineUsers = ReadTextFileToList("SMCL_data/OfflineUsersList.txt");
            OfflineUsers_upd(UsersListBox, OfflineUsers);
            javapath_upd(JavaPathComboBox, JavaPathList);
            JavaPathList = ReadTextFileToList("SMCL_data/JavaPathList.txt");
            {
                UsersComboBox.Items.Clear();
                UsersComboBox.Items.AddRange(OfflineUsers.ToArray());
                UsersComboBox.SelectedItem = INIRead("Data", "UsersComboboxSelectedItem");
            }//read users
            {
                string Maxmem_str = INIRead("GlobalGameSettings", "MaxMem");
                if (Maxmem_str != "")
                {
                    if (int.TryParse(Maxmem_str, out Maxmem))
                    {
                        Console.WriteLine("使用 int.TryParse() 转换: " + Maxmem);
                    }
                    else
                    {
                        Console.WriteLine("转换失败");
                        GameMemTextBox.Text = "16384";
                    }
                    GameMemTextBox.Text = Maxmem_str;
                }
                else { GameMemTextBox.Text = Maxmem.ToString(); }
            }//read max memory
            {
                if (int.TryParse(INIRead("AppearanceSettings", "SidebarWidth"), out SidebarWidth))
                {
                    if (SidebarWidth <= 0) { SidebarWidth = 160; }
                    Console.WriteLine("使用 int.TryParse() 转换: " + SidebarWidth);
                }
                else
                {
                    Console.WriteLine("转换失败");
                    SidebarWidth = 160;
                }
                TabControl.ItemSize = new(40, SidebarWidth - 1);
                SidebarWeightTextBox.Text = SidebarWidth.ToString();
            }//read Sidebar width
            {
                if (!Directory.Exists("SMCL_data"))
                {
                    Directory.CreateDirectory("SMCL_data");

                }
                else
                {
                    Console.WriteLine("文件夹已存在。");
                }
            }//create folders

            { JavaPathComboBox.SelectedItem = INIRead("GlobalGameSettings", "JavaComboboxSelectedItem"); }
            GamePathList = ReadList_strstr_FromFile("SMCL_data/GamePathList.txt");
            {
                GamePathListBox.Items.Clear();
                GamePathListBox.AddItems(GamePathNameList.ToArray());
                string str = INIRead("Data", "SelectedGamePathIndex");
                if (str != "")
                {
                    if (int.TryParse(str, out int index))
                    {
                        Console.WriteLine("使用 int.TryParse() 转换: " + index);
                    }
                    else
                    {
                        Console.WriteLine("转换失败");
                    }
                    GamePathListBox.SelectedIndex = index;
                }
                else { GamePathListBox.SelectedIndex = 0; }
            }//read selected game path
            FindVersions();
            GamePathNameList_upd();
            {
                VersionsComboBox.Items.Clear();
                VersionsComboBox.Items.AddRange(versions.ToArray());
                try
                {
                    gamepath = GamePathList[GamePathListBox.SelectedIndex].path;
                }catch { }
                Console.Write(gamepath);
                FindVersions();
                VersionsListBox.Clear(); VersionsListBox.Items.AddRange(versions);
                VersionsComboBox.Items.Clear(); VersionsComboBox.Items.AddRange(versions.ToArray());
                VersionsComboBox.SelectedItem = INIRead("Data", "VersionsComboboxSelectedItem");
            }//read versions
            UsersUuidList = ReadTextFileToList("SMCL_data/UsersUuidList.txt");
            VanillaListBox.AddItems(GetMC("release").ToArray());
            SnapshotListBox.AddItems(GetMC("snapshot").ToArray());
            OldVerListBox.AddItems(GetMC("old_beta").ToArray());
            OldVerListBox.AddItems(GetMC("old_alpha").ToArray());
        }

        private void RefreshSnapshotButton_Click(object sender, EventArgs e)
        {
            SnapshotListBox.Clear();
            SnapshotListBox.AddItems(GetMC("snapshot").ToArray());
        }
        private void RefreshReleaseButton_Click(object sender, EventArgs e)
        {
            VanillaListBox.Clear();
            VanillaListBox.AddItems(GetMC("release").ToArray());
        }

        private void VanillaListBox_SelectedIndexChanged(object sender)
        {
            if (VanillaListBox.SelectedIndex != -1)
            {
                _ = DownloadVanilla(VanillaListBox.SelectedText, MirrorDownloadManager.Bmcl);
                VanillaListBox.SelectedIndex = -1;
                FindVersions();
                VersionsListBox.Clear();
                VersionsListBox.AddItems(versions.ToArray());
            }
        }
        public void DelFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                FileSystem.DeleteDirectory(folderPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                Console.WriteLine("文件夹已成功删除。");
            }
            else
            {
                Console.WriteLine("指定的文件夹不存在。");
            }
        }
        private void DelVersionButton_Click(object sender, EventArgs e)
        {
            if (VersionsListBox.SelectedItem != null)
            {
                string path = gamepath + "/versions/" + VersionsListBox.SelectedText;
                DelFolder(path);
                FindVersions();
                VersionsListBox.Clear();
                VersionsListBox.AddItems(versions.ToArray());
                VersionsComboBox.Items.Clear();
                VersionsComboBox.Items.AddRange(versions.ToArray());
                VersionsComboBox.SelectedIndex = VersionsComboBox.Items.Count - 1;
            }
        }
        public double GetProcessUsedMemory()
        {
            double usedMemory = Process.GetCurrentProcess().WorkingSet64 / 1024.0 / 1024.0;
            return usedMemory;
        }
        private void OptimizationTimer_Tick(object sender, EventArgs e)
        {
            if (GetProcessUsedMemory() >= 20)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void VersionsComboBox_Click(object sender, EventArgs e)
        {
            if (VersionsComboBox.Items.Count <= 0) { TabControl.SelectedTab = DownloadTabPage; TabControl1.SelectedTab = DVanilla_TabPage; }
        }

        private void SnapshotListBox_SelectedIndexChanged(object sender)
        {
            if (SnapshotListBox.SelectedIndex != -1)
            {
                _ = DownloadVanilla(SnapshotListBox.SelectedText, MirrorDownloadManager.Bmcl);
                SnapshotListBox.SelectedIndex = -1;
                FindVersions();
                VersionsListBox.Clear();
                VersionsListBox.AddItems(versions.ToArray());
            }
        }
        private void OldVerListBox_SelectedIndexChanged(object sender)
        {
            if (OldVerListBox.SelectedIndex != -1)
            {
                _ = DownloadVanilla(OldVerListBox.SelectedText, MirrorDownloadManager.Bmcl);
                OldVerListBox.SelectedIndex = -1;
                FindVersions();
                VersionsListBox.Clear();
                VersionsListBox.AddItems(versions.ToArray());
            }
        }

        private void GameMemTextBox_TextChanged(object sender, EventArgs e)
        {
            INIWrite("GlobalGameSettings", "MaxMem", GameMemTextBox.Text);
            if (int.TryParse(GameMemTextBox.Text, out Maxmem))
            {
                Console.WriteLine("使用 int.TryParse() 转换: " + Maxmem);
            }
            else
            {
                Console.WriteLine("转换失败");
            }
        }

        private void RefreshOldverButton_Click(object sender, EventArgs e)
        {
            OldVerListBox.Clear();
            OldVerListBox.AddItems(GetMC("old_beta").ToArray());
            OldVerListBox.AddItems(GetMC("old_alpha").ToArray());
        }
    }
}
