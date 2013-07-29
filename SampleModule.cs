using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptCs;

namespace ScriptCs.SampleModule
{
    [Module("sample", Extensions = "csx")]
    public class SampleModule : IModule
    {
        public void Initialize(IModuleConfiguration config)
        {
            Console.WriteLine("Sample module initialized");
            config.FileSystem<TestFileSystem>();
        }
    }

    public class TestFileSystem : FileSystem
    {
        public TestFileSystem()
        {
            Console.WriteLine("TestFileSystem created");
        }
    }
}
