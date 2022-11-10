using System;
using System.Collections.Generic;
using Sandbox.ModAPI.Ingame;

namespace IngameScript.Mockups
{
#if !MOCKUP_DEBUG
    [System.Diagnostics.DebuggerNonUserCode]
#endif
    public class MockBlockGroup : IMyBlockGroup
    {
        readonly string name;
        readonly List<IMyTerminalBlock> blocks;

        public MockBlockGroup(string name)
        {
            this.name = name;
            this.blocks = new List<IMyTerminalBlock>();
        }

        public MockBlockGroup(string name, List<IMyTerminalBlock> blocks)
        {
            this.name = name;
            this.blocks = blocks;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void Add(IMyTerminalBlock block)
        {
            this.blocks.Add(block);
        }

        public void AddList(List<IMyTerminalBlock> blocks)
        {
            this.blocks.AddList(blocks);
        }

        void IMyBlockGroup.GetBlocks(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect)
        {
            blocks?.Clear();
            foreach (var block in this.blocks)
            {
                if (block is IMyTerminalBlock && (collect?.Invoke(block) ?? true))
                    blocks?.Add(block);
            }
        }

        void IMyBlockGroup.GetBlocksOfType<T>(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect)
        {
            blocks?.Clear();
            foreach (var block in this.blocks)
            {
                if (block is T && (collect?.Invoke(block) ?? true))
                    blocks?.Add(block);
            }
        }

        void Sandbox.ModAPI.Ingame.IMyBlockGroup.GetBlocksOfType<T>(List<T> blocks, Func<T, bool> collect)
        {
            blocks?.Clear();
            foreach (var block in this.blocks)
            {
                if (block is T && (collect?.Invoke((T)block) ?? true))
                    blocks?.Add((T)block);
            }
        }
    }
}
