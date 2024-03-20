using ECommons.Automation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LazySusan.Controllers
{
    public class RotationController
    {
        TaskManager _taskManager;
        public RotationController()
        {
            _taskManager = new TaskManager();
        }

    }
}
