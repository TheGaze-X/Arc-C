using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001612 RID: 5650
	[Token(Token = "0x2001612")]
	public class LuaUIContext : ILuaCallCSharp, ILuaDialog, ILoadAsset
	{
		// Token: 0x06008044 RID: 32836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008044")]
		[Address(RVA = "0x2891EE0", Offset = "0x2890AE0", VA = "0x182891EE0")]
		public static void SetDialogMgr(ILuaDialogMgr dialogMgr)
		{
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06008045 RID: 32837 RVA: 0x00038298 File Offset: 0x00036498
		[Token(Token = "0x17000F31")]
		public static bool inited
		{
			[Token(Token = "0x6008045")]
			[Address(RVA = "0x28921B0", Offset = "0x2890DB0", VA = "0x1828921B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008046")]
		[Address(RVA = "0x2891990", Offset = "0x2890590", VA = "0x182891990")]
		public void Open(IContextHost host)
		{
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008047")]
		[Address(RVA = "0x2890AB0", Offset = "0x288F6B0", VA = "0x182890AB0")]
		public void Close()
		{
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008048")]
		[Address(RVA = "0x2891D10", Offset = "0x2890910", VA = "0x182891D10", Slot = "7")]
		public void RequestClose(ILuaDialog child)
		{
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06008049 RID: 32841 RVA: 0x000382B0 File Offset: 0x000364B0
		[Token(Token = "0x17000F32")]
		public bool opened
		{
			[Token(Token = "0x6008049")]
			[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600804A")]
		[Address(RVA = "0x2891150", Offset = "0x288FD50", VA = "0x182891150", Slot = "5")]
		public Transform GetHookRoot()
		{
			return null;
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600804B")]
		[Address(RVA = "0x28914C0", Offset = "0x28900C0", VA = "0x1828914C0", Slot = "9")]
		public GameObject LoadPrefab(string path)
		{
			return null;
		}

		// Token: 0x0600804C RID: 32844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600804C")]
		[Address(RVA = "0x28913B0", Offset = "0x288FFB0", VA = "0x1828913B0", Slot = "10")]
		public LuaLayout LoadLayout(string path)
		{
			return null;
		}

		// Token: 0x0600804D RID: 32845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600804D")]
		[Address(RVA = "0x2891930", Offset = "0x2890530", VA = "0x182891930", Slot = "8")]
		public Sprite LoadSprite(string path)
		{
			return null;
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600804E")]
		[Address(RVA = "0x28915D0", Offset = "0x28901D0", VA = "0x1828915D0", Slot = "11")]
		public ScriptableObject LoadScriptableObject(string path)
		{
			return null;
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600804F")]
		[Address(RVA = "0x28916E0", Offset = "0x28902E0", VA = "0x1828916E0")]
		public Sprite LoadSpriteFromAutoPackHub(string hubPath, string spriteId)
		{
			return null;
		}

		// Token: 0x06008050 RID: 32848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008050")]
		[Address(RVA = "0x2891E20", Offset = "0x2890A20", VA = "0x182891E20")]
		public void SaveData(string key, string data)
		{
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008051")]
		[Address(RVA = "0x2891D60", Offset = "0x2890960", VA = "0x182891D60")]
		public void SaveDataBundle(string key, DataBundle data)
		{
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008052")]
		[Address(RVA = "0x28910E0", Offset = "0x288FCE0", VA = "0x1828910E0", Slot = "6")]
		public string GetData(string key)
		{
			return null;
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008053")]
		[Address(RVA = "0x2891070", Offset = "0x288FC70", VA = "0x182891070")]
		public DataBundle GetDataBundle(string key)
		{
			return null;
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06008054 RID: 32852 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008055 RID: 32853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F33")]
		public LuaTable paramData
		{
			[Token(Token = "0x6008054")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008055")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008056")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void ClosedByParent()
		{
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008057")]
		[Address(RVA = "0x2891230", Offset = "0x288FE30", VA = "0x182891230", Slot = "12")]
		public LuaLayout GetLuaLayout()
		{
			return null;
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008058")]
		[Address(RVA = "0x2891F40", Offset = "0x2890B40", VA = "0x182891F40", Slot = "13")]
		public void ShowEnterEffect()
		{
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x000382C8 File Offset: 0x000364C8
		[Token(Token = "0x6008059")]
		[Address(RVA = "0x2891310", Offset = "0x288FF10", VA = "0x182891310", Slot = "14")]
		public bool IsEnterEffectEnd()
		{
			return default(bool);
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600805A")]
		[Address(RVA = "0x2891FE0", Offset = "0x2890BE0", VA = "0x182891FE0", Slot = "15")]
		public UnityEngine.Object UICompDialogHost()
		{
			return null;
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600805B")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600805C")]
		[Address(RVA = "0x2891360", Offset = "0x288FF60", VA = "0x182891360", Slot = "17")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600805D")]
		[Address(RVA = "0x28920C0", Offset = "0x2890CC0", VA = "0x1828920C0", Slot = "18")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600805E")]
		[Address(RVA = "0x2890C70", Offset = "0x288F870", VA = "0x182890C70")]
		public object GetCompLuaBinder(string key)
		{
			return null;
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600805F")]
		[Address(RVA = "0x2892120", Offset = "0x2890D20", VA = "0x182892120")]
		private void _InitCompSystem(IContextHost host)
		{
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008060")]
		[Address(RVA = "0x2890FC0", Offset = "0x288FBC0", VA = "0x182890FC0")]
		public WeakReference GetComp(string key)
		{
			return null;
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008061")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LuaUIContext()
		{
		}

		// Token: 0x04008189 RID: 33161
		[Token(Token = "0x4008189")]
		[FieldOffset(Offset = "0x0")]
		private static ILuaDialogMgr s_mgr;

		// Token: 0x0400818A RID: 33162
		[Token(Token = "0x400818A")]
		[FieldOffset(Offset = "0x10")]
		private IContextHost m_host;

		// Token: 0x0400818B RID: 33163
		[Token(Token = "0x400818B")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> m_hostData;

		// Token: 0x0400818C RID: 33164
		[Token(Token = "0x400818C")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, DataBundle> m_hostDataBundle;

		// Token: 0x0400818D RID: 33165
		[Token(Token = "0x400818D")]
		[FieldOffset(Offset = "0x28")]
		private ILuaDialog m_child;

		// Token: 0x0400818F RID: 33167
		[Token(Token = "0x400818F")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, LuaUIContext.Comp> m_comps;

		// Token: 0x04008190 RID: 33168
		[Token(Token = "0x4008190")]
		[FieldOffset(Offset = "0x40")]
		private IDictionary<string, Type> m_compDeclaration;

		// Token: 0x02001613 RID: 5651
		[Token(Token = "0x2001613")]
		public class Comp : IDisposable
		{
			// Token: 0x06008063 RID: 32867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008063")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Comp()
			{
			}

			// Token: 0x06008064 RID: 32868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008064")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			protected void SaveInst(object inst)
			{
			}

			// Token: 0x06008065 RID: 32869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008065")]
			[Address(RVA = "0x2886C20", Offset = "0x2885820", VA = "0x182886C20")]
			public WeakReference GetInst()
			{
				return null;
			}

			// Token: 0x06008066 RID: 32870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008066")]
			[Address(RVA = "0x1DEED20", Offset = "0x1DED920", VA = "0x181DEED20", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04008191 RID: 33169
			[Token(Token = "0x4008191")]
			[FieldOffset(Offset = "0x10")]
			private object m_inst;
		}
	}
}
