using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A2D RID: 27181
	[Token(Token = "0x2006A2D")]
	public class Main11RecordNoteUnlockTipsItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026DA0 RID: 159136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DA0")]
		[Address(RVA = "0x21F3700", Offset = "0x21F2300", VA = "0x1821F3700")]
		public void Render(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026DA1 RID: 159137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DA1")]
		[Address(RVA = "0x21F3B00", Offset = "0x21F2700", VA = "0x1821F3B00")]
		private void _UpdateDiffIcons(ZoneRecordViewModel.ZoneRecordDiffStatus diffStatus)
		{
		}

		// Token: 0x06026DA2 RID: 159138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DA2")]
		[Address(RVA = "0x21F3840", Offset = "0x21F2440", VA = "0x1821F3840")]
		private void _AddDiffStatusToList(RecordRewardStageDiff status, ref List<RecordRewardStageDiff> diffList)
		{
		}

		// Token: 0x06026DA3 RID: 159139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DA3")]
		[Address(RVA = "0x21F3990", Offset = "0x21F2590", VA = "0x1821F3990")]
		private void _RenderDiffIcons(List<RecordRewardStageDiff> diffStatusList)
		{
		}

		// Token: 0x06026DA4 RID: 159140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DA4")]
		[Address(RVA = "0x21F3D90", Offset = "0x21F2990", VA = "0x1821F3D90")]
		public Main11RecordNoteUnlockTipsItemView()
		{
		}

		// Token: 0x04036EDD RID: 224989
		[Token(Token = "0x4036EDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _unlockTips;

		// Token: 0x04036EDE RID: 224990
		[Token(Token = "0x4036EDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main11RecordNoteUnlockTipsItemView.StageDiffImage[] _diffIconList;

		// Token: 0x04036EDF RID: 224991
		[Token(Token = "0x4036EDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _styleRecordNameCol;

		// Token: 0x04036EE0 RID: 224992
		[Token(Token = "0x4036EE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _styleTipsCol;

		// Token: 0x04036EE1 RID: 224993
		[Token(Token = "0x4036EE1")]
		private const string TIPS_STYLE = "<color=#{0}>{1}</color>";

		// Token: 0x04036EE2 RID: 224994
		[Token(Token = "0x4036EE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036EE3 RID: 224995
		[Token(Token = "0x4036EE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateDiffIcons;

		// Token: 0x04036EE4 RID: 224996
		[Token(Token = "0x4036EE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddDiffStatusToList;

		// Token: 0x04036EE5 RID: 224997
		[Token(Token = "0x4036EE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDiffIcons;

		// Token: 0x04036EE6 RID: 224998
		[Token(Token = "0x4036EE6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A2E RID: 27182
		[Token(Token = "0x2006A2E")]
		[Serializable]
		private struct StageDiffImage
		{
			// Token: 0x04036EE7 RID: 224999
			[Token(Token = "0x4036EE7")]
			[FieldOffset(Offset = "0x0")]
			public RecordRewardStageDiff diff;

			// Token: 0x04036EE8 RID: 225000
			[Token(Token = "0x4036EE8")]
			[FieldOffset(Offset = "0x8")]
			public GameObject objIcon;
		}
	}
}
