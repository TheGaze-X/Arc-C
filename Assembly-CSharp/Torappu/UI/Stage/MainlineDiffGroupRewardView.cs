using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006786 RID: 26502
	[Token(Token = "0x2006786")]
	public class MainlineDiffGroupRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170059ED RID: 23021
		// (get) Token: 0x06026046 RID: 155718 RVA: 0x000C9B10 File Offset: 0x000C7D10
		[Token(Token = "0x170059ED")]
		public bool cacheAutoSelect
		{
			[Token(Token = "0x6026046")]
			[Address(RVA = "0x20FC970", Offset = "0x20FB570", VA = "0x1820FC970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026047 RID: 155719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026047")]
		[Address(RVA = "0x20FC7E0", Offset = "0x20FB3E0", VA = "0x1820FC7E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026048 RID: 155720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026048")]
		[Address(RVA = "0x20FC270", Offset = "0x20FAE70", VA = "0x1820FC270")]
		public void Render(StageViewModel stageViewModel, bool isToSquad)
		{
		}

		// Token: 0x06026049 RID: 155721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026049")]
		[Address(RVA = "0x20FC1F0", Offset = "0x20FADF0", VA = "0x1820FC1F0")]
		public void ChangeClickNotShow()
		{
		}

		// Token: 0x0602604A RID: 155722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602604A")]
		[Address(RVA = "0x20FC910", Offset = "0x20FB510", VA = "0x1820FC910")]
		public MainlineDiffGroupRewardView()
		{
		}

		// Token: 0x040357BB RID: 219067
		[Token(Token = "0x40357BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040357BC RID: 219068
		[Token(Token = "0x40357BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _showNextTimeToggle;

		// Token: 0x040357BD RID: 219069
		[Token(Token = "0x40357BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _buttonContainer;

		// Token: 0x040357BE RID: 219070
		[Token(Token = "0x40357BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _allApCost;

		// Token: 0x040357BF RID: 219071
		[Token(Token = "0x40357BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _selectPart;

		// Token: 0x040357C0 RID: 219072
		[Token(Token = "0x40357C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x040357C1 RID: 219073
		[Token(Token = "0x40357C1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _onStageRewardClick;

		// Token: 0x040357C2 RID: 219074
		[Token(Token = "0x40357C2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cacheAutoSelect;

		// Token: 0x040357C3 RID: 219075
		[Token(Token = "0x40357C3")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isInited;

		// Token: 0x040357C4 RID: 219076
		[Token(Token = "0x40357C4")]
		[FieldOffset(Offset = "0x58")]
		private MainlineDiffGroupRewardView.Adatper m_adapter;

		// Token: 0x040357C5 RID: 219077
		[Token(Token = "0x40357C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cacheAutoSelect;

		// Token: 0x040357C6 RID: 219078
		[Token(Token = "0x40357C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040357C7 RID: 219079
		[Token(Token = "0x40357C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040357C8 RID: 219080
		[Token(Token = "0x40357C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeClickNotShow;

		// Token: 0x040357C9 RID: 219081
		[Token(Token = "0x40357C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006787 RID: 26503
		[Token(Token = "0x2006787")]
		private class Adatper : SimpleLayoutAdapter
		{
			// Token: 0x170059EE RID: 23022
			// (get) Token: 0x0602604B RID: 155723 RVA: 0x000C9B28 File Offset: 0x000C7D28
			[Token(Token = "0x170059EE")]
			public override int count
			{
				[Token(Token = "0x602604B")]
				[Address(RVA = "0x20EEC90", Offset = "0x20ED890", VA = "0x1820EEC90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602604C RID: 155724 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602604C")]
			[Address(RVA = "0x20EEA40", Offset = "0x20ED640", VA = "0x1820EEA40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602604D RID: 155725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602604D")]
			[Address(RVA = "0x20EEC30", Offset = "0x20ED830", VA = "0x1820EEC30")]
			public Adatper()
			{
			}

			// Token: 0x040357CA RID: 219082
			[Token(Token = "0x40357CA")]
			[FieldOffset(Offset = "0x20")]
			public UIStringEvent onRewardClick;

			// Token: 0x040357CB RID: 219083
			[Token(Token = "0x40357CB")]
			[FieldOffset(Offset = "0x28")]
			public List<StageBattleDiffGroupInfo.StageInfo> stageList;

			// Token: 0x040357CC RID: 219084
			[Token(Token = "0x40357CC")]
			[FieldOffset(Offset = "0x30")]
			public string selectStageId;

			// Token: 0x040357CD RID: 219085
			[Token(Token = "0x40357CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040357CE RID: 219086
			[Token(Token = "0x40357CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040357CF RID: 219087
			[Token(Token = "0x40357CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
