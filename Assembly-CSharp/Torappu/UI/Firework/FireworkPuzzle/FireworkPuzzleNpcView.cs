using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E6E RID: 20078
	[Token(Token = "0x2004E6E")]
	public class FireworkPuzzleNpcView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DF72 RID: 122738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF72")]
		[Address(RVA = "0x17AB0F0", Offset = "0x17A9CF0", VA = "0x1817AB0F0")]
		public void Render(FireworkPuzzleDetailModel detailModel)
		{
		}

		// Token: 0x0601DF73 RID: 122739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF73")]
		[Address(RVA = "0x17AB640", Offset = "0x17AA240", VA = "0x1817AB640")]
		private void _PlayDialogTweenIfNeed(bool isShow)
		{
		}

		// Token: 0x0601DF74 RID: 122740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF74")]
		[Address(RVA = "0x17AB5B0", Offset = "0x17AA1B0", VA = "0x1817AB5B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DF75 RID: 122741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF75")]
		[Address(RVA = "0x17AB770", Offset = "0x17AA370", VA = "0x1817AB770")]
		private void _PlayTextTween(string rawDesc)
		{
		}

		// Token: 0x0601DF76 RID: 122742 RVA: 0x000AD088 File Offset: 0x000AB288
		[Token(Token = "0x601DF76")]
		[Address(RVA = "0x17AB8F0", Offset = "0x17AA4F0", VA = "0x1817AB8F0")]
		private bool _TryGetNextDialogType(FireworkPuzzleDetailModel detailModel, out Act38SideData.NpcDialogType dialogType)
		{
			return default(bool);
		}

		// Token: 0x0601DF77 RID: 122743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF77")]
		[Address(RVA = "0x17ABC90", Offset = "0x17AA890", VA = "0x1817ABC90")]
		public FireworkPuzzleNpcView()
		{
		}

		// Token: 0x04027CAE RID: 162990
		[Token(Token = "0x4027CAE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UISpineWrapper _spineWrapper;

		// Token: 0x04027CAF RID: 162991
		[Token(Token = "0x4027CAF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04027CB0 RID: 162992
		[Token(Token = "0x4027CB0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _textTweenDuration;

		// Token: 0x04027CB1 RID: 162993
		[Token(Token = "0x4027CB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animDialogShow;

		// Token: 0x04027CB2 RID: 162994
		[Token(Token = "0x4027CB2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animDialogHide;

		// Token: 0x04027CB3 RID: 162995
		[Token(Token = "0x4027CB3")]
		[FieldOffset(Offset = "0x50")]
		private int m_cacheEnterSeqNum;

		// Token: 0x04027CB4 RID: 162996
		[Token(Token = "0x4027CB4")]
		[FieldOffset(Offset = "0x54")]
		private int m_cacheAddSeqNum;

		// Token: 0x04027CB5 RID: 162997
		[Token(Token = "0x4027CB5")]
		[FieldOffset(Offset = "0x58")]
		private int m_cacheRemoveSeqNum;

		// Token: 0x04027CB6 RID: 162998
		[Token(Token = "0x4027CB6")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cacheHintSuccSeqNum;

		// Token: 0x04027CB7 RID: 162999
		[Token(Token = "0x4027CB7")]
		[FieldOffset(Offset = "0x60")]
		private int m_cacheHintFailSeqNum;

		// Token: 0x04027CB8 RID: 163000
		[Token(Token = "0x4027CB8")]
		[FieldOffset(Offset = "0x64")]
		private bool m_hasInited;

		// Token: 0x04027CB9 RID: 163001
		[Token(Token = "0x4027CB9")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_textTween;

		// Token: 0x04027CBA RID: 163002
		[Token(Token = "0x4027CBA")]
		[FieldOffset(Offset = "0x70")]
		private FireworkNpcDialogModel m_cacheDialogModel;

		// Token: 0x04027CBB RID: 163003
		[Token(Token = "0x4027CBB")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_dialogTween;

		// Token: 0x04027CBC RID: 163004
		[Token(Token = "0x4027CBC")]
		[FieldOffset(Offset = "0x80")]
		private bool m_cacheDialogVisible;

		// Token: 0x04027CBD RID: 163005
		[Token(Token = "0x4027CBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027CBE RID: 163006
		[Token(Token = "0x4027CBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayDialogTweenIfNeed;

		// Token: 0x04027CBF RID: 163007
		[Token(Token = "0x4027CBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027CC0 RID: 163008
		[Token(Token = "0x4027CC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayTextTween;

		// Token: 0x04027CC1 RID: 163009
		[Token(Token = "0x4027CC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryGetNextDialogType;

		// Token: 0x04027CC2 RID: 163010
		[Token(Token = "0x4027CC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
