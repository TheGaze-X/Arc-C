using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B92 RID: 27538
	[Token(Token = "0x2006B92")]
	public class ArchiveFragmentModel : IHotfixable
	{
		// Token: 0x17005CE9 RID: 23785
		// (get) Token: 0x06027559 RID: 161113 RVA: 0x000CE160 File Offset: 0x000CC360
		[Token(Token = "0x17005CE9")]
		public int newItemCount
		{
			[Token(Token = "0x6027559")]
			[Address(RVA = "0x2284430", Offset = "0x2283030", VA = "0x182284430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602755A RID: 161114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602755A")]
		[Address(RVA = "0x2283020", Offset = "0x2281C20", VA = "0x182283020")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData)
		{
		}

		// Token: 0x0602755B RID: 161115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602755B")]
		[Address(RVA = "0x2283980", Offset = "0x2282580", VA = "0x182283980")]
		public void SetSelectedItem(string id)
		{
		}

		// Token: 0x0602755C RID: 161116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602755C")]
		[Address(RVA = "0x2283E30", Offset = "0x2282A30", VA = "0x182283E30")]
		private string _GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x0602755D RID: 161117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602755D")]
		[Address(RVA = "0x2283B60", Offset = "0x2282760", VA = "0x182283B60")]
		private void _GenerateGroupModel()
		{
		}

		// Token: 0x0602755E RID: 161118 RVA: 0x000CE178 File Offset: 0x000CC378
		[Token(Token = "0x602755E")]
		[Address(RVA = "0x2284250", Offset = "0x2282E50", VA = "0x182284250")]
		private static RoguelikeArchiveItemUnlockStatus _GetStatusOfItem(PlayerRoguelikeV2.OuterData outerData, string fragmentId)
		{
			return RoguelikeArchiveItemUnlockStatus.LOCKED;
		}

		// Token: 0x0602755F RID: 161119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602755F")]
		[Address(RVA = "0x2283F10", Offset = "0x2282B10", VA = "0x182283F10")]
		private static string _GetLockedToastOfItem(string archiveId, RoguelikeTopicDetail topicDetail, RoguelikeTopicItemModel itemInfo, RoguelikeArchiveItemUnlockStatus status)
		{
			return null;
		}

		// Token: 0x06027560 RID: 161120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027560")]
		[Address(RVA = "0x2284330", Offset = "0x2282F30", VA = "0x182284330")]
		public ArchiveFragmentModel()
		{
		}

		// Token: 0x04037B9B RID: 228251
		[Token(Token = "0x4037B9B")]
		[FieldOffset(Offset = "0x10")]
		public string selectedItemId;

		// Token: 0x04037B9C RID: 228252
		[Token(Token = "0x4037B9C")]
		[FieldOffset(Offset = "0x18")]
		public FragmentItemModel selectedItemModel;

		// Token: 0x04037B9D RID: 228253
		[Token(Token = "0x4037B9D")]
		[FieldOffset(Offset = "0x20")]
		public List<ArchiveFragmentGroupModel> groupModelList;

		// Token: 0x04037B9E RID: 228254
		[Token(Token = "0x4037B9E")]
		[FieldOffset(Offset = "0x28")]
		public bool showSwitchAnim;

		// Token: 0x04037B9F RID: 228255
		[Token(Token = "0x4037B9F")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, FragmentItemModel> m_fragmentList;

		// Token: 0x04037BA0 RID: 228256
		[Token(Token = "0x4037BA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_newItemCount;

		// Token: 0x04037BA1 RID: 228257
		[Token(Token = "0x4037BA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037BA2 RID: 228258
		[Token(Token = "0x4037BA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedItem;

		// Token: 0x04037BA3 RID: 228259
		[Token(Token = "0x4037BA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDefaultItemId;

		// Token: 0x04037BA4 RID: 228260
		[Token(Token = "0x4037BA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateGroupModel;

		// Token: 0x04037BA5 RID: 228261
		[Token(Token = "0x4037BA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetStatusOfItem;

		// Token: 0x04037BA6 RID: 228262
		[Token(Token = "0x4037BA6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetLockedToastOfItem;

		// Token: 0x04037BA7 RID: 228263
		[Token(Token = "0x4037BA7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
