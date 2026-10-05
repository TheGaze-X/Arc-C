using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C5E RID: 27742
	[Token(Token = "0x2006C5E")]
	public class ArchiveWrathController : ActArchiveController, IHotfixable
	{
		// Token: 0x17005D91 RID: 23953
		// (get) Token: 0x0602798B RID: 162187 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602798C RID: 162188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D91")]
		public Action<ActArchiveType, string> onItemClicked
		{
			[Token(Token = "0x602798B")]
			[Address(RVA = "0x22C7B90", Offset = "0x22C6790", VA = "0x1822C7B90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602798C")]
			[Address(RVA = "0x22C7BF0", Offset = "0x22C67F0", VA = "0x1822C7BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D92 RID: 23954
		// (get) Token: 0x0602798D RID: 162189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D92")]
		public ArchiveWrathDataBinder dataBinder
		{
			[Token(Token = "0x602798D")]
			[Address(RVA = "0x22C7B30", Offset = "0x22C6730", VA = "0x1822C7B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602798E RID: 162190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602798E")]
		[Address(RVA = "0x22C79B0", Offset = "0x22C65B0", VA = "0x1822C79B0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x0602798F RID: 162191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602798F")]
		[Address(RVA = "0x22C7870", Offset = "0x22C6470", VA = "0x1822C7870")]
		public Sprite LoadWrathSmallIcon(string archiveId, string iconId)
		{
			return null;
		}

		// Token: 0x06027990 RID: 162192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027990")]
		[Address(RVA = "0x22C77D0", Offset = "0x22C63D0", VA = "0x1822C77D0")]
		public Sprite LoadWrathLargeIcon(string archiveId, string iconId)
		{
			return null;
		}

		// Token: 0x06027991 RID: 162193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027991")]
		[Address(RVA = "0x22C7910", Offset = "0x22C6510", VA = "0x1822C7910")]
		public Sprite LoadWrathTitleIcon(string archiveId, string iconId)
		{
			return null;
		}

		// Token: 0x06027992 RID: 162194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027992")]
		[Address(RVA = "0x22C7AD0", Offset = "0x22C66D0", VA = "0x1822C7AD0")]
		public ArchiveWrathController()
		{
		}

		// Token: 0x06027993 RID: 162195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027993")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x0403827E RID: 230014
		[Token(Token = "0x403827E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveWrathDataBinder _wrathDataBinder;

		// Token: 0x04038280 RID: 230016
		[Token(Token = "0x4038280")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04038281 RID: 230017
		[Token(Token = "0x4038281")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04038282 RID: 230018
		[Token(Token = "0x4038282")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x04038283 RID: 230019
		[Token(Token = "0x4038283")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04038284 RID: 230020
		[Token(Token = "0x4038284")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadWrathSmallIcon;

		// Token: 0x04038285 RID: 230021
		[Token(Token = "0x4038285")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadWrathLargeIcon;

		// Token: 0x04038286 RID: 230022
		[Token(Token = "0x4038286")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadWrathTitleIcon;

		// Token: 0x04038287 RID: 230023
		[Token(Token = "0x4038287")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
