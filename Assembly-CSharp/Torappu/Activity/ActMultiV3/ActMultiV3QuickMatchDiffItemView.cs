using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F94 RID: 28564
	[Token(Token = "0x2006F94")]
	public abstract class ActMultiV3QuickMatchDiffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060288AC RID: 166060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288AC")]
		[Address(RVA = "0x23D4130", Offset = "0x23D2D30", VA = "0x1823D4130", Slot = "4")]
		protected virtual void OnRender()
		{
		}

		// Token: 0x060288AD RID: 166061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288AD")]
		[Address(RVA = "0x23DE900", Offset = "0x23DD500", VA = "0x1823DE900")]
		public void Render(ActMultiV3QuickMatchModel matchModel, ActMultiV3MatchModeGroupModel modeGroupModel, ActMultiV3MatchModeDiffModel diffModel)
		{
		}

		// Token: 0x060288AE RID: 166062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288AE")]
		[Address(RVA = "0x23DE7F0", Offset = "0x23DD3F0", VA = "0x1823DE7F0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x060288AF RID: 166063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288AF")]
		[Address(RVA = "0x23DEB00", Offset = "0x23DD700", VA = "0x1823DEB00")]
		protected ActMultiV3QuickMatchDiffItemView()
		{
		}

		// Token: 0x04039BBA RID: 236474
		[Token(Token = "0x4039BBA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04039BBB RID: 236475
		[Token(Token = "0x4039BBB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorNameUnselect;

		// Token: 0x04039BBC RID: 236476
		[Token(Token = "0x4039BBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorNameSelect;

		// Token: 0x04039BBD RID: 236477
		[Token(Token = "0x4039BBD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _unselectBgGO;

		// Token: 0x04039BBE RID: 236478
		[Token(Token = "0x4039BBE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectBgGO;

		// Token: 0x04039BBF RID: 236479
		[Token(Token = "0x4039BBF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _lockPartGO;

		// Token: 0x04039BC0 RID: 236480
		[Token(Token = "0x4039BC0")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039BC1 RID: 236481
		[Token(Token = "0x4039BC1")]
		[FieldOffset(Offset = "0x68")]
		protected ActMultiV3QuickMatchModel m_matchModel;

		// Token: 0x04039BC2 RID: 236482
		[Token(Token = "0x4039BC2")]
		[FieldOffset(Offset = "0x70")]
		protected ActMultiV3MatchModeGroupModel m_modeGroupModel;

		// Token: 0x04039BC3 RID: 236483
		[Token(Token = "0x4039BC3")]
		[FieldOffset(Offset = "0x78")]
		protected ActMultiV3MatchModeDiffModel m_diffModel;

		// Token: 0x04039BC4 RID: 236484
		[Token(Token = "0x4039BC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039BC5 RID: 236485
		[Token(Token = "0x4039BC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039BC6 RID: 236486
		[Token(Token = "0x4039BC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04039BC7 RID: 236487
		[Token(Token = "0x4039BC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
