using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200483A RID: 18490
	[Token(Token = "0x200483A")]
	public class MonopolySettleView : DataBinder<MonopolySettleProperty>
	{
		// Token: 0x0601BEEE RID: 114414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEEE")]
		[Address(RVA = "0x155C830", Offset = "0x155B430", VA = "0x18155C830", Slot = "7")]
		public override void OnValueChanged(MonopolySettleProperty property)
		{
		}

		// Token: 0x0601BEEF RID: 114415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEEF")]
		[Address(RVA = "0x155D0F0", Offset = "0x155BCF0", VA = "0x18155D0F0")]
		private void _RenderSettleTypeGroup(MonopolySettleModel model)
		{
		}

		// Token: 0x0601BEF0 RID: 114416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEF0")]
		[Address(RVA = "0x155CD70", Offset = "0x155B970", VA = "0x18155CD70")]
		private void _PlayEntryTween(MonopolySettleModel model)
		{
		}

		// Token: 0x0601BEF1 RID: 114417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEF1")]
		[Address(RVA = "0x155CBD0", Offset = "0x155B7D0", VA = "0x18155CBD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BEF2 RID: 114418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEF2")]
		[Address(RVA = "0x155C780", Offset = "0x155B380", VA = "0x18155C780")]
		public void OnClickContinueBtn()
		{
		}

		// Token: 0x0601BEF3 RID: 114419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEF3")]
		[Address(RVA = "0x155D3B0", Offset = "0x155BFB0", VA = "0x18155D3B0")]
		public MonopolySettleView()
		{
		}

		// Token: 0x040246C1 RID: 149185
		[Token(Token = "0x40246C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string TARGET_FORMAT;

		// Token: 0x040246C2 RID: 149186
		[Token(Token = "0x40246C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _failAnimLocation;

		// Token: 0x040246C3 RID: 149187
		[Token(Token = "0x40246C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _successAnimLocation;

		// Token: 0x040246C4 RID: 149188
		[Token(Token = "0x40246C4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _excellentAnimLocation;

		// Token: 0x040246C5 RID: 149189
		[Token(Token = "0x40246C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x040246C6 RID: 149190
		[Token(Token = "0x40246C6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<MonopolySettleView.SettleTypeGroup> _settleTypeGroups;

		// Token: 0x040246C7 RID: 149191
		[Token(Token = "0x40246C7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _resourceContent;

		// Token: 0x040246C8 RID: 149192
		[Token(Token = "0x40246C8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _dialogText;

		// Token: 0x040246C9 RID: 149193
		[Token(Token = "0x40246C9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _dialogCharAvatarId;

		// Token: 0x040246CA RID: 149194
		[Token(Token = "0x40246CA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _canContinueDuration;

		// Token: 0x040246CB RID: 149195
		[Token(Token = "0x40246CB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Font _kjeragDigitFont;

		// Token: 0x040246CC RID: 149196
		[Token(Token = "0x40246CC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text[] _textUseKjeragFont;

		// Token: 0x040246CD RID: 149197
		[Token(Token = "0x40246CD")]
		[FieldOffset(Offset = "0x90")]
		private MonopolySettleView.MonopolySettleResourceAdapter m_adapter;

		// Token: 0x040246CE RID: 149198
		[Token(Token = "0x40246CE")]
		[FieldOffset(Offset = "0x98")]
		private ListDict<string, int> m_cachedResourceDict;

		// Token: 0x040246CF RID: 149199
		[Token(Token = "0x40246CF")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x040246D0 RID: 149200
		[Token(Token = "0x40246D0")]
		[FieldOffset(Offset = "0xA8")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x040246D1 RID: 149201
		[Token(Token = "0x40246D1")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_entryTween;

		// Token: 0x040246D2 RID: 149202
		[Token(Token = "0x40246D2")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_canContinue;

		// Token: 0x040246D3 RID: 149203
		[Token(Token = "0x40246D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040246D4 RID: 149204
		[Token(Token = "0x40246D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSettleTypeGroup;

		// Token: 0x040246D5 RID: 149205
		[Token(Token = "0x40246D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEntryTween;

		// Token: 0x040246D6 RID: 149206
		[Token(Token = "0x40246D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040246D7 RID: 149207
		[Token(Token = "0x40246D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickContinueBtn;

		// Token: 0x040246D8 RID: 149208
		[Token(Token = "0x40246D8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200483B RID: 18491
		[Token(Token = "0x200483B")]
		public class MonopolySettleResourceAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601BEF5 RID: 114421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEF5")]
			[Address(RVA = "0x155C3D0", Offset = "0x155AFD0", VA = "0x18155C3D0")]
			public MonopolySettleResourceAdapter(MonopolySettleView closure)
			{
			}

			// Token: 0x17004257 RID: 16983
			// (get) Token: 0x0601BEF6 RID: 114422 RVA: 0x000A6AB8 File Offset: 0x000A4CB8
			[Token(Token = "0x17004257")]
			public override int count
			{
				[Token(Token = "0x601BEF6")]
				[Address(RVA = "0x155C450", Offset = "0x155B050", VA = "0x18155C450", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BEF7 RID: 114423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BEF7")]
			[Address(RVA = "0x155C1A0", Offset = "0x155ADA0", VA = "0x18155C1A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040246D9 RID: 149209
			[Token(Token = "0x40246D9")]
			[FieldOffset(Offset = "0x20")]
			private MonopolySettleView m_closure;

			// Token: 0x040246DA RID: 149210
			[Token(Token = "0x40246DA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040246DB RID: 149211
			[Token(Token = "0x40246DB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040246DC RID: 149212
			[Token(Token = "0x40246DC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200483C RID: 18492
		[Token(Token = "0x200483C")]
		[Serializable]
		public class SettleTypeGroup
		{
			// Token: 0x0601BEF8 RID: 114424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEF8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SettleTypeGroup()
			{
			}

			// Token: 0x040246DD RID: 149213
			[Token(Token = "0x40246DD")]
			[FieldOffset(Offset = "0x10")]
			public Act46SideData.Act46SideSettleType settleType;

			// Token: 0x040246DE RID: 149214
			[Token(Token = "0x40246DE")]
			[FieldOffset(Offset = "0x18")]
			public Text score;

			// Token: 0x040246DF RID: 149215
			[Token(Token = "0x40246DF")]
			[FieldOffset(Offset = "0x20")]
			public Text target;

			// Token: 0x040246E0 RID: 149216
			[Token(Token = "0x40246E0")]
			[FieldOffset(Offset = "0x28")]
			public GameObject highScoreObj;
		}
	}
}
