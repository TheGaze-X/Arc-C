using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006991 RID: 27025
	[Token(Token = "0x2006991")]
	public class StageZoneSelectBlackLoadingManager : IHotfixable
	{
		// Token: 0x17005B4D RID: 23373
		// (get) Token: 0x06026AB7 RID: 158391 RVA: 0x000CBF58 File Offset: 0x000CA158
		[Token(Token = "0x17005B4D")]
		public bool isShowing
		{
			[Token(Token = "0x6026AB7")]
			[Address(RVA = "0x21CE6A0", Offset = "0x21CD2A0", VA = "0x1821CE6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026AB8 RID: 158392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AB8")]
		[Address(RVA = "0x21CE5D0", Offset = "0x21CD1D0", VA = "0x1821CE5D0")]
		public StageZoneSelectBlackLoadingManager(CanvasGroup alphaHandler)
		{
		}

		// Token: 0x06026AB9 RID: 158393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AB9")]
		[Address(RVA = "0x21CE560", Offset = "0x21CD160", VA = "0x1821CE560")]
		private void _OnHideEffect()
		{
		}

		// Token: 0x06026ABA RID: 158394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ABA")]
		[Address(RVA = "0x21CE360", Offset = "0x21CCF60", VA = "0x1821CE360")]
		public void SetShow(long instId, StageZoneSelectBlackLoadingManager.BlackLoadingType showType = StageZoneSelectBlackLoadingManager.BlackLoadingType.DEFAULT, bool fastMode = false)
		{
		}

		// Token: 0x06026ABB RID: 158395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ABB")]
		[Address(RVA = "0x21CE230", Offset = "0x21CCE30", VA = "0x1821CE230")]
		public void SetHide(long instId, StageZoneSelectBlackLoadingManager.BlackLoadingType showType = StageZoneSelectBlackLoadingManager.BlackLoadingType.DEFAULT)
		{
		}

		// Token: 0x04036973 RID: 223603
		[Token(Token = "0x4036973")]
		[FieldOffset(Offset = "0x10")]
		private FadeSwitchTween m_FadeSwitchTween;

		// Token: 0x04036974 RID: 223604
		[Token(Token = "0x4036974")]
		[FieldOffset(Offset = "0x18")]
		private FadeSwitchTween m_BlackMaskFadeSwitchTween;

		// Token: 0x04036975 RID: 223605
		[Token(Token = "0x4036975")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<long> m_showInstSet;

		// Token: 0x04036976 RID: 223606
		[Token(Token = "0x4036976")]
		[FieldOffset(Offset = "0x28")]
		private CanvasGroup m_alphaHandler;

		// Token: 0x04036977 RID: 223607
		[Token(Token = "0x4036977")]
		[FieldOffset(Offset = "0x30")]
		private StageZoneSelectBlackLoadingManager.StageZoneSelectBlackLoadingTweener m_tweener;

		// Token: 0x04036978 RID: 223608
		[Token(Token = "0x4036978")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShowing;

		// Token: 0x04036979 RID: 223609
		[Token(Token = "0x4036979")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403697A RID: 223610
		[Token(Token = "0x403697A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnHideEffect;

		// Token: 0x0403697B RID: 223611
		[Token(Token = "0x403697B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0403697C RID: 223612
		[Token(Token = "0x403697C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetHide;

		// Token: 0x02006992 RID: 27026
		[Token(Token = "0x2006992")]
		public enum BlackLoadingType
		{
			// Token: 0x0403697E RID: 223614
			[Token(Token = "0x403697E")]
			DEFAULT,
			// Token: 0x0403697F RID: 223615
			[Token(Token = "0x403697F")]
			BLACK_MASK_FADE
		}

		// Token: 0x02006993 RID: 27027
		[Token(Token = "0x2006993")]
		public class StageZoneSelectBlackLoadingTweener
		{
			// Token: 0x06026ABC RID: 158396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026ABC")]
			[Address(RVA = "0x21CE8B0", Offset = "0x21CD4B0", VA = "0x1821CE8B0")]
			public StageZoneSelectBlackLoadingTweener(CanvasGroup alphaHandler, Action onHideEffect, StageZoneSelectBlackLoadingManager.BlackLoadingType blackLoadingType)
			{
			}

			// Token: 0x17005B4E RID: 23374
			// (get) Token: 0x06026ABD RID: 158397 RVA: 0x000CBF70 File Offset: 0x000CA170
			[Token(Token = "0x17005B4E")]
			public StageZoneSelectBlackLoadingManager.BlackLoadingType blackLoadingType
			{
				[Token(Token = "0x6026ABD")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return StageZoneSelectBlackLoadingManager.BlackLoadingType.DEFAULT;
				}
			}

			// Token: 0x17005B4F RID: 23375
			// (get) Token: 0x06026ABE RID: 158398 RVA: 0x000CBF88 File Offset: 0x000CA188
			[Token(Token = "0x17005B4F")]
			public bool isShowing
			{
				[Token(Token = "0x6026ABE")]
				[Address(RVA = "0x21CEAE0", Offset = "0x21CD6E0", VA = "0x1821CEAE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06026ABF RID: 158399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026ABF")]
			[Address(RVA = "0x21CE7E0", Offset = "0x21CD3E0", VA = "0x1821CE7E0")]
			public void SetShow(long instId, bool fastMode = false)
			{
			}

			// Token: 0x06026AC0 RID: 158400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026AC0")]
			[Address(RVA = "0x21CE730", Offset = "0x21CD330", VA = "0x1821CE730")]
			public void SetHide(long instId)
			{
			}

			// Token: 0x04036980 RID: 223616
			[Token(Token = "0x4036980")]
			[FieldOffset(Offset = "0x10")]
			private readonly Dictionary<StageZoneSelectBlackLoadingManager.BlackLoadingType, float> BLACK_LOADING_TYPE_DURATION_DICT;

			// Token: 0x04036981 RID: 223617
			[Token(Token = "0x4036981")]
			[FieldOffset(Offset = "0x18")]
			private FadeSwitchTween m_FadeSwitchTween;

			// Token: 0x04036982 RID: 223618
			[Token(Token = "0x4036982")]
			[FieldOffset(Offset = "0x20")]
			private StageZoneSelectBlackLoadingManager.BlackLoadingType m_blackLoadingType;

			// Token: 0x04036983 RID: 223619
			[Token(Token = "0x4036983")]
			[FieldOffset(Offset = "0x28")]
			private HashSet<long> m_showInstSet;
		}
	}
}
