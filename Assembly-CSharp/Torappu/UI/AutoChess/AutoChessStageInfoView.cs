using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006390 RID: 25488
	[Token(Token = "0x2006390")]
	public class AutoChessStageInfoView : DataBinder<AutoChessStageInfoProperty>, IHotfixable
	{
		// Token: 0x06024C37 RID: 150583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C37")]
		[Address(RVA = "0x1FABD00", Offset = "0x1FAA900", VA = "0x181FABD00", Slot = "7")]
		public override void OnValueChanged(AutoChessStageInfoProperty property)
		{
		}

		// Token: 0x06024C38 RID: 150584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C38")]
		[Address(RVA = "0x1FABC70", Offset = "0x1FAA870", VA = "0x181FABC70")]
		public void EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x06024C39 RID: 150585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C39")]
		[Address(RVA = "0x1FAC110", Offset = "0x1FAAD10", VA = "0x181FAC110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C3A RID: 150586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C3A")]
		[Address(RVA = "0x1FAC230", Offset = "0x1FAAE30", VA = "0x181FAC230")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x06024C3B RID: 150587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C3B")]
		[Address(RVA = "0x1FAC2F0", Offset = "0x1FAAEF0", VA = "0x181FAC2F0")]
		public AutoChessStageInfoView()
		{
		}

		// Token: 0x040335CE RID: 210382
		[Token(Token = "0x40335CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessStageInfoView.DifficultyInfo[] _difficultyInfoList;

		// Token: 0x040335CF RID: 210383
		[Token(Token = "0x40335CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMode;

		// Token: 0x040335D0 RID: 210384
		[Token(Token = "0x40335D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPlayerInfo;

		// Token: 0x040335D1 RID: 210385
		[Token(Token = "0x40335D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _contentPlayer;

		// Token: 0x040335D2 RID: 210386
		[Token(Token = "0x40335D2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textConfirmPlayerCount;

		// Token: 0x040335D3 RID: 210387
		[Token(Token = "0x40335D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textPlayerCount;

		// Token: 0x040335D4 RID: 210388
		[Token(Token = "0x40335D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelBtn;

		// Token: 0x040335D5 RID: 210389
		[Token(Token = "0x40335D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelConfirmed;

		// Token: 0x040335D6 RID: 210390
		[Token(Token = "0x40335D6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelConfirmBtn;

		// Token: 0x040335D7 RID: 210391
		[Token(Token = "0x40335D7")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x040335D8 RID: 210392
		[Token(Token = "0x40335D8")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessStageInfoView.Adapter m_adapter;

		// Token: 0x040335D9 RID: 210393
		[Token(Token = "0x40335D9")]
		[FieldOffset(Offset = "0x78")]
		private int m_cachedConfirmedPlayerCount;

		// Token: 0x040335DA RID: 210394
		[Token(Token = "0x40335DA")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cachedTotalPlayerCount;

		// Token: 0x040335DB RID: 210395
		[Token(Token = "0x40335DB")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040335DC RID: 210396
		[Token(Token = "0x40335DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040335DD RID: 210397
		[Token(Token = "0x40335DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClicked;

		// Token: 0x040335DE RID: 210398
		[Token(Token = "0x40335DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040335DF RID: 210399
		[Token(Token = "0x40335DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x040335E0 RID: 210400
		[Token(Token = "0x40335E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006391 RID: 25489
		[Token(Token = "0x2006391")]
		[Serializable]
		public struct DifficultyInfo
		{
			// Token: 0x040335E1 RID: 210401
			[Token(Token = "0x40335E1")]
			[FieldOffset(Offset = "0x0")]
			public ActAutoChessModeDifficultyType difficulty;

			// Token: 0x040335E2 RID: 210402
			[Token(Token = "0x40335E2")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelMode;
		}

		// Token: 0x02006392 RID: 25490
		[Token(Token = "0x2006392")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06024C3C RID: 150588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024C3C")]
			[Address(RVA = "0x1F96DB0", Offset = "0x1F959B0", VA = "0x181F96DB0")]
			public Adapter(AutoChessStageInfoView closure)
			{
			}

			// Token: 0x170056C9 RID: 22217
			// (get) Token: 0x06024C3D RID: 150589 RVA: 0x000C5688 File Offset: 0x000C3888
			[Token(Token = "0x170056C9")]
			public override int count
			{
				[Token(Token = "0x6024C3D")]
				[Address(RVA = "0x1F96F30", Offset = "0x1F95B30", VA = "0x181F96F30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024C3E RID: 150590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024C3E")]
			[Address(RVA = "0x1F96590", Offset = "0x1F95190", VA = "0x181F96590", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040335E3 RID: 210403
			[Token(Token = "0x40335E3")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessStageInfoView m_closure;

			// Token: 0x040335E4 RID: 210404
			[Token(Token = "0x40335E4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040335E5 RID: 210405
			[Token(Token = "0x40335E5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040335E6 RID: 210406
			[Token(Token = "0x40335E6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
