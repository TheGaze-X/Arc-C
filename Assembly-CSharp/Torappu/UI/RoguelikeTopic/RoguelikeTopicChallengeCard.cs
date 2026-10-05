using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044A5 RID: 17573
	[Token(Token = "0x20044A5")]
	public class RoguelikeTopicChallengeCard : MonoBehaviour, LoopPagePicker.IPageView, IHotfixable
	{
		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0601AD89 RID: 109961 RVA: 0x000A3788 File Offset: 0x000A1988
		// (set) Token: 0x0601AD8A RID: 109962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FB7")]
		public float fade
		{
			[Token(Token = "0x601AD89")]
			[Address(RVA = "0x13FE2C0", Offset = "0x13FCEC0", VA = "0x1813FE2C0", Slot = "4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601AD8A")]
			[Address(RVA = "0x13FE380", Offset = "0x13FCF80", VA = "0x1813FE380", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x0601AD8B RID: 109963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FB8")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x601AD8B")]
			[Address(RVA = "0x13FE320", Offset = "0x13FCF20", VA = "0x1813FE320", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AD8C RID: 109964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD8C")]
		[Address(RVA = "0x13FDAF0", Offset = "0x13FC6F0", VA = "0x1813FDAF0")]
		public void Render(string topicId, RoguelikeTopicChallengeModel model, RoguelikeTopicChallengeModelStyle style)
		{
		}

		// Token: 0x0601AD8D RID: 109965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD8D")]
		[Address(RVA = "0x13FDA90", Offset = "0x13FC690", VA = "0x1813FDA90")]
		public void EventOnShowDesc()
		{
		}

		// Token: 0x0601AD8E RID: 109966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD8E")]
		[Address(RVA = "0x13FDA30", Offset = "0x13FC630", VA = "0x1813FDA30")]
		public void EventOnCloseDesc()
		{
		}

		// Token: 0x0601AD8F RID: 109967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD8F")]
		[Address(RVA = "0x13FDF60", Offset = "0x13FCB60", VA = "0x1813FDF60")]
		private void _TweenToShowDetail(bool showDetail)
		{
		}

		// Token: 0x0601AD90 RID: 109968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD90")]
		[Address(RVA = "0x13FDEB0", Offset = "0x13FCAB0", VA = "0x1813FDEB0")]
		private void _CleanTween()
		{
		}

		// Token: 0x0601AD91 RID: 109969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD91")]
		[Address(RVA = "0x13FE250", Offset = "0x13FCE50", VA = "0x1813FE250")]
		public RoguelikeTopicChallengeCard()
		{
		}

		// Token: 0x0601AD92 RID: 109970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD92")]
		[Address(RVA = "0x13FDE50", Offset = "0x13FCA50", VA = "0x1813FDE50", Slot = "7")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04022610 RID: 140816
		[Token(Token = "0x4022610")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _transform;

		// Token: 0x04022611 RID: 140817
		[Token(Token = "0x4022611")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _colorChanger;

		// Token: 0x04022612 RID: 140818
		[Token(Token = "0x4022612")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _darkColor;

		// Token: 0x04022613 RID: 140819
		[Token(Token = "0x4022613")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _cover;

		// Token: 0x04022614 RID: 140820
		[Token(Token = "0x4022614")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _detailNode;

		// Token: 0x04022615 RID: 140821
		[Token(Token = "0x4022615")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _hideFade;

		// Token: 0x04022616 RID: 140822
		[Token(Token = "0x4022616")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _name;

		// Token: 0x04022617 RID: 140823
		[Token(Token = "0x4022617")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _completeTag;

		// Token: 0x04022618 RID: 140824
		[Token(Token = "0x4022618")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("InitRes")]
		private Text _initHp;

		// Token: 0x04022619 RID: 140825
		[Token(Token = "0x4022619")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("InitRes")]
		private Text _initPopulation;

		// Token: 0x0402261A RID: 140826
		[Token(Token = "0x402261A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("InitRes")]
		private Text _initGold;

		// Token: 0x0402261B RID: 140827
		[Token(Token = "0x402261B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("InitRes")]
		private Text _initCapacity;

		// Token: 0x0402261C RID: 140828
		[Token(Token = "0x402261C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _descNode;

		// Token: 0x0402261D RID: 140829
		[Token(Token = "0x402261D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _descLabel;

		// Token: 0x0402261E RID: 140830
		[Token(Token = "0x402261E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _descTweenDur;

		// Token: 0x0402261F RID: 140831
		[Token(Token = "0x402261F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeTopicChallengeCardPlugin _plugin;

		// Token: 0x04022620 RID: 140832
		[Token(Token = "0x4022620")]
		[FieldOffset(Offset = "0xA0")]
		private float m_fade;

		// Token: 0x04022621 RID: 140833
		[Token(Token = "0x4022621")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_hideTween;

		// Token: 0x04022622 RID: 140834
		[Token(Token = "0x4022622")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_showTween;

		// Token: 0x04022623 RID: 140835
		[Token(Token = "0x4022623")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fade;

		// Token: 0x04022624 RID: 140836
		[Token(Token = "0x4022624")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_fade;

		// Token: 0x04022625 RID: 140837
		[Token(Token = "0x4022625")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x04022626 RID: 140838
		[Token(Token = "0x4022626")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022627 RID: 140839
		[Token(Token = "0x4022627")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnShowDesc;

		// Token: 0x04022628 RID: 140840
		[Token(Token = "0x4022628")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCloseDesc;

		// Token: 0x04022629 RID: 140841
		[Token(Token = "0x4022629")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TweenToShowDetail;

		// Token: 0x0402262A RID: 140842
		[Token(Token = "0x402262A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CleanTween;

		// Token: 0x0402262B RID: 140843
		[Token(Token = "0x402262B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402262C RID: 140844
		[Token(Token = "0x402262C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge get_gameObject;
	}
}
