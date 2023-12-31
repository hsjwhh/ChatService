﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace ChatService
{
    public partial class ChatService : ServiceBase
    {
        private ChatServer chatServer;

        public ChatService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            chatServer = new ChatServer();
            chatServer.Start();
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            chatServer.DisconnectServer();
        }
    }
}
