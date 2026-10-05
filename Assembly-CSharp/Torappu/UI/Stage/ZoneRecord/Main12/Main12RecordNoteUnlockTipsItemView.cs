using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A13 RID: 27155
	[Token(Token = "0x2006A13")]
	public class Main12RecordNoteUnlockTipsItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026D24 RID: 159012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D24")]
		[Address(RVA = "0x21F6B80", Offset = "0x21F5780", VA = "0x1821F6B80")]
		public void Render(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026D25 RID: 159013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D25")]
		[Address(RVA = "0x21F74E0", Offset = "0x21F60E0", VA = "0x1821F74E0")]
		private void _UpdateDiffIcons(ZoneRecordViewModel.ZoneRecordDiffStatus diffStatus, ListDict<RecordRewardStageDiff, string> diffMap)
		{
		}

		// Token: 0x06026D26 RID: 159014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D26")]
		[Address(RVA = "0x21F7040", Offset = "0x21F5C40", VA = "0x1821F7040")]
		private void _AddDiffStatusToList(RecordRewardStageDiff status, ref List<RecordRewardStageDiff> diffList)
		{
		}

		// Token: 0x06026D27 RID: 159015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D27")]
		[Address(RVA = "0x21F72E0", Offset = "0x21F5EE0", VA = "0x1821F72E0")]
		private void _RenderDiffIcons(List<RecordRewardStageDiff> diffStatusList, ListDict<RecordRewardStageDiff, string> diffMap)
		{
		}

		// Token: 0x06026D28 RID: 159016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D28")]
		[Address(RVA = "0x21F7190", Offset = "0x21F5D90", VA = "0x1821F7190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D29 RID: 159017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D29")]
		[Address(RVA = "0x21F7650", Offset = "0x21F6250", VA = "0x1821F7650")]
		public Main12RecordNoteUnlockTipsItemView()
		{
		}

		// Token: 0x04036DBD RID: 224701
		[Token(Token = "0x4036DBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _unlockTips;

		// Token: 0x04036DBE RID: 224702
		[Token(Token = "0x4036DBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main12RecordNoteUnlockTipsItemView.StageDiffImage[] _diffIconList;

		// Token: 0x04036DBF RID: 224703
		[Token(Token = "0x4036DBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _styleRecordNameCol;

		// Token: 0x04036DC0 RID: 224704
		[Token(Token = "0x4036DC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _styleTipsCol;

		// Token: 0x04036DC1 RID: 224705
		[Token(Token = "0x4036DC1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _missionContent;

		// Token: 0x04036DC2 RID: 224706
		[Token(Token = "0x4036DC2")]
		private const string TIPS_STYLE = "<color=#{0}>{1}</color>";

		// Token: 0x04036DC3 RID: 224707
		[Token(Token = "0x4036DC3")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04036DC4 RID: 224708
		[Token(Token = "0x4036DC4")]
		[FieldOffset(Offset = "0x48")]
		private Main12RecordNoteUnlockTipsItemView.MissionAdapter m_adapter;

		// Token: 0x04036DC5 RID: 224709
		[Token(Token = "0x4036DC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036DC6 RID: 224710
		[Token(Token = "0x4036DC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateDiffIcons;

		// Token: 0x04036DC7 RID: 224711
		[Token(Token = "0x4036DC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddDiffStatusToList;

		// Token: 0x04036DC8 RID: 224712
		[Token(Token = "0x4036DC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDiffIcons;

		// Token: 0x04036DC9 RID: 224713
		[Token(Token = "0x4036DC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036DCA RID: 224714
		[Token(Token = "0x4036DCA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A14 RID: 27156
		[Token(Token = "0x2006A14")]
		[Serializable]
		private struct StageDiffImage
		{
			// Token: 0x04036DCB RID: 224715
			[Token(Token = "0x4036DCB")]
			[FieldOffset(Offset = "0x0")]
			public RecordRewardStageDiff diff;

			// Token: 0x04036DCC RID: 224716
			[Token(Token = "0x4036DCC")]
			[FieldOffset(Offset = "0x8")]
			public GameObject objIcon;

			// Token: 0x04036DCD RID: 224717
			[Token(Token = "0x4036DCD")]
			[FieldOffset(Offset = "0x10")]
			public GameObject missionIcon;
		}

		// Token: 0x02006A15 RID: 27157
		[Token(Token = "0x2006A15")]
		private class MissionAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005B9F RID: 23455
			// (get) Token: 0x06026D2A RID: 159018 RVA: 0x000CC768 File Offset: 0x000CA968
			[Token(Token = "0x17005B9F")]
			public override int count
			{
				[Token(Token = "0x6026D2A")]
				[Address(RVA = "0x21FB7F0", Offset = "0x21FA3F0", VA = "0x1821FB7F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026D2B RID: 159019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026D2B")]
			[Address(RVA = "0x21FB4F0", Offset = "0x21FA0F0", VA = "0x1821FB4F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026D2C RID: 159020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D2C")]
			[Address(RVA = "0x21FB790", Offset = "0x21FA390", VA = "0x1821FB790")]
			public MissionAdapter()
			{
			}

			// Token: 0x04036DCE RID: 224718
			[Token(Token = "0x4036DCE")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<RecordRewardStageDiff, string> missionData;

			// Token: 0x04036DCF RID: 224719
			[Token(Token = "0x4036DCF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036DD0 RID: 224720
			[Token(Token = "0x4036DD0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04036DD1 RID: 224721
			[Token(Token = "0x4036DD1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
