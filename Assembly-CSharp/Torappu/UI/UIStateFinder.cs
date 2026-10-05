using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003644 RID: 13892
	[Token(Token = "0x2003644")]
	public struct UIStateFinder
	{
		// Token: 0x060161C4 RID: 90564 RVA: 0x0008F730 File Offset: 0x0008D930
		[Token(Token = "0x60161C4")]
		[Address(RVA = "0xEA65D0", Offset = "0xEA51D0", VA = "0x180EA65D0")]
		public UIStateFinder.Interface Reset(Transform current)
		{
			return default(UIStateFinder.Interface);
		}

		// Token: 0x060161C5 RID: 90565 RVA: 0x0008F748 File Offset: 0x0008D948
		[Token(Token = "0x60161C5")]
		[Address(RVA = "0xEA64A0", Offset = "0xEA50A0", VA = "0x180EA64A0")]
		public UIStateFinder.Interface Current(Transform current)
		{
			return default(UIStateFinder.Interface);
		}

		// Token: 0x060161C6 RID: 90566 RVA: 0x0008F760 File Offset: 0x0008D960
		[Token(Token = "0x60161C6")]
		[Address(RVA = "0xEA6410", Offset = "0xEA5010", VA = "0x180EA6410")]
		public UIStateFinder.Interface Current(MonoBehaviour customBehavior)
		{
			return default(UIStateFinder.Interface);
		}

		// Token: 0x0401A969 RID: 108905
		[Token(Token = "0x401A969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private State m_state;

		// Token: 0x0401A96A RID: 108906
		[Token(Token = "0x401A96A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Transform m_curTrans;

		// Token: 0x02003645 RID: 13893
		[Token(Token = "0x2003645")]
		public struct Interface
		{
			// Token: 0x060161C7 RID: 90567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60161C7")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public Interface(State state)
			{
			}

			// Token: 0x060161C8 RID: 90568 RVA: 0x0008F778 File Offset: 0x0008D978
			[Token(Token = "0x60161C8")]
			[Address(RVA = "0xE92530", Offset = "0xE91130", VA = "0x180E92530")]
			public bool IsSameState(State comparsion)
			{
				return default(bool);
			}

			// Token: 0x060161C9 RID: 90569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60161C9")]
			public TAsset LoadAsset<TAsset>(string path) where TAsset : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x060161CA RID: 90570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60161CA")]
			[Address(RVA = "0xE923E0", Offset = "0xE90FE0", VA = "0x180E923E0")]
			public ILoadAsset GetAssetLoader()
			{
				return null;
			}

			// Token: 0x060161CB RID: 90571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60161CB")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public UnityEngine.Object UICompDialogHost()
			{
				return null;
			}

			// Token: 0x060161CC RID: 90572 RVA: 0x0008F790 File Offset: 0x0008D990
			[Token(Token = "0x60161CC")]
			public bool SendMessage<StateType>(int key, ValueBundle msg) where StateType : State, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x060161CD RID: 90573 RVA: 0x0008F7A8 File Offset: 0x0008D9A8
			[Token(Token = "0x60161CD")]
			public bool SendMessage<StateType>(int key) where StateType : State, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x060161CE RID: 90574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60161CE")]
			[Address(RVA = "0xE92260", Offset = "0xE90E60", VA = "0x180E92260")]
			public IValueMsgReceiver AsValueMsgReceiver()
			{
				return null;
			}

			// Token: 0x060161CF RID: 90575 RVA: 0x0008F7C0 File Offset: 0x0008D9C0
			[Token(Token = "0x60161CF")]
			[Address(RVA = "0xE922A0", Offset = "0xE90EA0", VA = "0x180E922A0")]
			public bool CheckIsTransiting()
			{
				return default(bool);
			}

			// Token: 0x060161D0 RID: 90576 RVA: 0x0008F7D8 File Offset: 0x0008D9D8
			[Token(Token = "0x60161D0")]
			[Address(RVA = "0xE92350", Offset = "0xE90F50", VA = "0x180E92350")]
			public bool CheckIsUICoreCompStable([Optional] Type expectedStateType, [Optional] string expectedPageName)
			{
				return default(bool);
			}

			// Token: 0x0401A96B RID: 108907
			[Token(Token = "0x401A96B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private State m_state;
		}
	}
}
