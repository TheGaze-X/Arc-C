using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075FD RID: 30205
	[Token(Token = "0x20075FD")]
	public class Act24sideQuestPage : StateEnginePage, IDialogMgrHolder
	{
		// Token: 0x170063FF RID: 25599
		// (get) Token: 0x0602A865 RID: 174181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170063FF")]
		public string actId
		{
			[Token(Token = "0x602A865")]
			[Address(RVA = "0x262FB50", Offset = "0x262E750", VA = "0x18262FB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006400 RID: 25600
		// (get) Token: 0x0602A866 RID: 174182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006400")]
		public string selectStageId
		{
			[Token(Token = "0x602A866")]
			[Address(RVA = "0x262FBB0", Offset = "0x262E7B0", VA = "0x18262FBB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A867 RID: 174183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A867")]
		[Address(RVA = "0x262F940", Offset = "0x262E540", VA = "0x18262F940", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602A868 RID: 174184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A868")]
		[Address(RVA = "0x262FA20", Offset = "0x262E620", VA = "0x18262FA20", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602A869 RID: 174185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A869")]
		[Address(RVA = "0x262F700", Offset = "0x262E300", VA = "0x18262F700")]
		public DataBundle CreateRecoverDataBundleForBattle(string selectStageId)
		{
			return null;
		}

		// Token: 0x0602A86A RID: 174186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A86A")]
		[Address(RVA = "0x262F8E0", Offset = "0x262E4E0", VA = "0x18262F8E0", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0602A86B RID: 174187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A86B")]
		[Address(RVA = "0x262FAF0", Offset = "0x262E6F0", VA = "0x18262FAF0")]
		public Act24sideQuestPage()
		{
		}

		// Token: 0x0602A86C RID: 174188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A86C")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602A86D RID: 174189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A86D")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0403D373 RID: 250739
		[Token(Token = "0x403D373")]
		public const string KEY_PARAM_BUNDLE = "key_act24side_quest_page_param";

		// Token: 0x0403D374 RID: 250740
		[Token(Token = "0x403D374")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403D375 RID: 250741
		[Token(Token = "0x403D375")]
		[FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x0403D376 RID: 250742
		[Token(Token = "0x403D376")]
		[FieldOffset(Offset = "0x100")]
		private string m_selectStageId;

		// Token: 0x0403D377 RID: 250743
		[Token(Token = "0x403D377")]
		[FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0403D378 RID: 250744
		[Token(Token = "0x403D378")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403D379 RID: 250745
		[Token(Token = "0x403D379")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectStageId;

		// Token: 0x0403D37A RID: 250746
		[Token(Token = "0x403D37A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403D37B RID: 250747
		[Token(Token = "0x403D37B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403D37C RID: 250748
		[Token(Token = "0x403D37C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateRecoverDataBundleForBattle;

		// Token: 0x0403D37D RID: 250749
		[Token(Token = "0x403D37D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0403D37E RID: 250750
		[Token(Token = "0x403D37E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075FE RID: 30206
		[Token(Token = "0x20075FE")]
		public class Param : ICustomPageParam, IHotfixable
		{
			// Token: 0x0602A86E RID: 174190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A86E")]
			[Address(RVA = "0x2634670", Offset = "0x2633270", VA = "0x182634670")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x0602A86F RID: 174191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A86F")]
			[Address(RVA = "0x2634520", Offset = "0x2633120", VA = "0x182634520")]
			public static Act24sideQuestPage.Param Deserialize(string str)
			{
				return null;
			}

			// Token: 0x0602A870 RID: 174192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A870")]
			[Address(RVA = "0x26346F0", Offset = "0x26332F0", VA = "0x1826346F0")]
			public Param()
			{
			}

			// Token: 0x0403D37F RID: 250751
			[Token(Token = "0x403D37F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403D380 RID: 250752
			[Token(Token = "0x403D380")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x0403D381 RID: 250753
			[Token(Token = "0x403D381")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Serialize;

			// Token: 0x0403D382 RID: 250754
			[Token(Token = "0x403D382")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Deserialize;

			// Token: 0x0403D383 RID: 250755
			[Token(Token = "0x403D383")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
