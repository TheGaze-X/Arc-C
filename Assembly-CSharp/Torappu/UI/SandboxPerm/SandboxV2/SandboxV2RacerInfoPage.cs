using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004373 RID: 17267
	[Token(Token = "0x2004373")]
	public class SandboxV2RacerInfoPage : StateEnginePage, ISandboxV2DialogHolder, IHotfixable
	{
		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x0601A7D5 RID: 108501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EE8")]
		public string topicId
		{
			[Token(Token = "0x601A7D5")]
			[Address(RVA = "0x138D8C0", Offset = "0x138C4C0", VA = "0x18138D8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x0601A7D6 RID: 108502 RVA: 0x000A1FB8 File Offset: 0x000A01B8
		[Token(Token = "0x17003EE9")]
		public SandboxV2RacerInfoPage.Type type
		{
			[Token(Token = "0x601A7D6")]
			[Address(RVA = "0x138D970", Offset = "0x138C570", VA = "0x18138D970")]
			get
			{
				return SandboxV2RacerInfoPage.Type.NONE;
			}
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x0601A7D7 RID: 108503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EEA")]
		public string nodeId
		{
			[Token(Token = "0x601A7D7")]
			[Address(RVA = "0x138D760", Offset = "0x138C360", VA = "0x18138D760")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x0601A7D8 RID: 108504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EEB")]
		public string stageId
		{
			[Token(Token = "0x601A7D8")]
			[Address(RVA = "0x138D810", Offset = "0x138C410", VA = "0x18138D810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x0601A7D9 RID: 108505 RVA: 0x000A1FD0 File Offset: 0x000A01D0
		[Token(Token = "0x17003EEC")]
		public int apCost
		{
			[Token(Token = "0x601A7D9")]
			[Address(RVA = "0x138D660", Offset = "0x138C260", VA = "0x18138D660")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A7DA RID: 108506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7DA")]
		[Address(RVA = "0x138D510", Offset = "0x138C110", VA = "0x18138D510", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601A7DB RID: 108507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7DB")]
		[Address(RVA = "0x138D460", Offset = "0x138C060", VA = "0x18138D460", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x0601A7DC RID: 108508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EED")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601A7DC")]
			[Address(RVA = "0x138D700", Offset = "0x138C300", VA = "0x18138D700", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A7DD RID: 108509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7DD")]
		[Address(RVA = "0x138D320", Offset = "0x138BF20", VA = "0x18138D320")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601A7DE RID: 108510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7DE")]
		[Address(RVA = "0x138D5F0", Offset = "0x138C1F0", VA = "0x18138D5F0")]
		public SandboxV2RacerInfoPage()
		{
		}

		// Token: 0x0601A7E0 RID: 108512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7E0")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601A7E1 RID: 108513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7E1")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04021B77 RID: 138103
		[Token(Token = "0x4021B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04021B78 RID: 138104
		[Token(Token = "0x4021B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string m_nodeId;

		// Token: 0x04021B79 RID: 138105
		[Token(Token = "0x4021B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string m_topicId;

		// Token: 0x04021B7A RID: 138106
		[Token(Token = "0x4021B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string m_stageId;

		// Token: 0x04021B7B RID: 138107
		[Token(Token = "0x4021B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int m_apCost;

		// Token: 0x04021B7C RID: 138108
		[Token(Token = "0x4021B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private SandboxV2RacerInfoPage.Type m_type;

		// Token: 0x04021B7D RID: 138109
		[Token(Token = "0x4021B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04021B7E RID: 138110
		[Token(Token = "0x4021B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04021B7F RID: 138111
		[Token(Token = "0x4021B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04021B80 RID: 138112
		[Token(Token = "0x4021B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_nodeId;

		// Token: 0x04021B81 RID: 138113
		[Token(Token = "0x4021B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x04021B82 RID: 138114
		[Token(Token = "0x4021B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_apCost;

		// Token: 0x04021B83 RID: 138115
		[Token(Token = "0x4021B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04021B84 RID: 138116
		[Token(Token = "0x4021B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04021B85 RID: 138117
		[Token(Token = "0x4021B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04021B86 RID: 138118
		[Token(Token = "0x4021B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x04021B87 RID: 138119
		[Token(Token = "0x4021B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004374 RID: 17268
		[Token(Token = "0x2004374")]
		public enum Type
		{
			// Token: 0x04021B89 RID: 138121
			[Token(Token = "0x4021B89")]
			NONE,
			// Token: 0x04021B8A RID: 138122
			[Token(Token = "0x4021B8A")]
			INVENTORY,
			// Token: 0x04021B8B RID: 138123
			[Token(Token = "0x4021B8B")]
			START_BATTLE
		}

		// Token: 0x02004375 RID: 17269
		[Token(Token = "0x2004375")]
		public class Params
		{
			// Token: 0x0601A7E2 RID: 108514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A7E2")]
			[Address(RVA = "0x1385070", Offset = "0x1383C70", VA = "0x181385070")]
			public Params()
			{
			}

			// Token: 0x04021B8C RID: 138124
			[Token(Token = "0x4021B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04021B8D RID: 138125
			[Token(Token = "0x4021B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SandboxV2RacerInfoPage.Type type;

			// Token: 0x04021B8E RID: 138126
			[Token(Token = "0x4021B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string nodeId;

			// Token: 0x04021B8F RID: 138127
			[Token(Token = "0x4021B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string stageId;

			// Token: 0x04021B90 RID: 138128
			[Token(Token = "0x4021B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int apCost;
		}
	}
}
