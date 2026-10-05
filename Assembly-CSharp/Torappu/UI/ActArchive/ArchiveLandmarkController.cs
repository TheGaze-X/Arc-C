using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B96 RID: 27542
	[Token(Token = "0x2006B96")]
	public class ArchiveLandmarkController : ActArchiveController
	{
		// Token: 0x0602756D RID: 161133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602756D")]
		[Address(RVA = "0x2284660", Offset = "0x2283260", VA = "0x182284660", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x0602756E RID: 161134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602756E")]
		[Address(RVA = "0x2284530", Offset = "0x2283130", VA = "0x182284530")]
		public List<DataBinder<LandmarkProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x0602756F RID: 161135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602756F")]
		[Address(RVA = "0x22846E0", Offset = "0x22832E0", VA = "0x1822846E0")]
		public ArchiveLandmarkController()
		{
		}

		// Token: 0x06027570 RID: 161136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027570")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x04037BB2 RID: 228274
		[Token(Token = "0x4037BB2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveLandmarkDataBinder _landmarkBinder;

		// Token: 0x04037BB3 RID: 228275
		[Token(Token = "0x4037BB3")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<ActArchiveType, string> onLandmarkItemClicked;

		// Token: 0x04037BB4 RID: 228276
		[Token(Token = "0x4037BB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037BB5 RID: 228277
		[Token(Token = "0x4037BB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037BB6 RID: 228278
		[Token(Token = "0x4037BB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
