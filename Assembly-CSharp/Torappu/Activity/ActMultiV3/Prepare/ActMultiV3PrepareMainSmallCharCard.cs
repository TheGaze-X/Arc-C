using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007045 RID: 28741
	[Token(Token = "0x2007045")]
	public class ActMultiV3PrepareMainSmallCharCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700606F RID: 24687
		// (get) Token: 0x06028CD4 RID: 167124 RVA: 0x000D3110 File Offset: 0x000D1310
		// (set) Token: 0x06028CD5 RID: 167125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700606F")]
		public bool enableTempTag
		{
			[Token(Token = "0x6028CD4")]
			[Address(RVA = "0x243EB70", Offset = "0x243D770", VA = "0x18243EB70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028CD5")]
			[Address(RVA = "0x243ECB0", Offset = "0x243D8B0", VA = "0x18243ECB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006070 RID: 24688
		// (set) Token: 0x06028CD6 RID: 167126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006070")]
		public bool enableClick
		{
			[Token(Token = "0x6028CD6")]
			[Address(RVA = "0x243EC30", Offset = "0x243D830", VA = "0x18243EC30")]
			set
			{
			}
		}

		// Token: 0x17006071 RID: 24689
		// (set) Token: 0x06028CD7 RID: 167127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006071")]
		public Action<int> onClick
		{
			[Token(Token = "0x6028CD7")]
			[Address(RVA = "0x243ED20", Offset = "0x243D920", VA = "0x18243ED20")]
			set
			{
			}
		}

		// Token: 0x17006072 RID: 24690
		// (get) Token: 0x06028CD8 RID: 167128 RVA: 0x000D3128 File Offset: 0x000D1328
		// (set) Token: 0x06028CD9 RID: 167129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006072")]
		public bool tempTagValid
		{
			[Token(Token = "0x6028CD8")]
			[Address(RVA = "0x243EBD0", Offset = "0x243D7D0", VA = "0x18243EBD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028CD9")]
			[Address(RVA = "0x243EDA0", Offset = "0x243D9A0", VA = "0x18243EDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028CDA RID: 167130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CDA")]
		[Address(RVA = "0x243E720", Offset = "0x243D320", VA = "0x18243E720")]
		public void RenderCard(ActMultiV3PrepareMainSmallCharCardModel model)
		{
		}

		// Token: 0x06028CDB RID: 167131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CDB")]
		[Address(RVA = "0x243E9E0", Offset = "0x243D5E0", VA = "0x18243E9E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028CDC RID: 167132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CDC")]
		[Address(RVA = "0x243E690", Offset = "0x243D290", VA = "0x18243E690")]
		public void EventOnClick()
		{
		}

		// Token: 0x06028CDD RID: 167133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CDD")]
		[Address(RVA = "0x243EB10", Offset = "0x243D710", VA = "0x18243EB10")]
		public ActMultiV3PrepareMainSmallCharCard()
		{
		}

		// Token: 0x0403A2F4 RID: 238324
		[Token(Token = "0x403A2F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActMultiV3CharCardBase _cardPrefab;

		// Token: 0x0403A2F5 RID: 238325
		[Token(Token = "0x403A2F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403A2F6 RID: 238326
		[Token(Token = "0x403A2F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _btnGraphic;

		// Token: 0x0403A2F7 RID: 238327
		[Token(Token = "0x403A2F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _teampTag;

		// Token: 0x0403A2F8 RID: 238328
		[Token(Token = "0x403A2F8")]
		[FieldOffset(Offset = "0x38")]
		private ActMultiV3CharCardBase m_card;

		// Token: 0x0403A2F9 RID: 238329
		[Token(Token = "0x403A2F9")]
		[FieldOffset(Offset = "0x40")]
		private Action<int> m_clickListener;

		// Token: 0x0403A2FA RID: 238330
		[Token(Token = "0x403A2FA")]
		[FieldOffset(Offset = "0x48")]
		private ActMultiV3PrepareMainSmallCharCardModel m_cachedModel;

		// Token: 0x0403A2FD RID: 238333
		[Token(Token = "0x403A2FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enableTempTag;

		// Token: 0x0403A2FE RID: 238334
		[Token(Token = "0x403A2FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_enableTempTag;

		// Token: 0x0403A2FF RID: 238335
		[Token(Token = "0x403A2FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_enableClick;

		// Token: 0x0403A300 RID: 238336
		[Token(Token = "0x403A300")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403A301 RID: 238337
		[Token(Token = "0x403A301")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tempTagValid;

		// Token: 0x0403A302 RID: 238338
		[Token(Token = "0x403A302")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tempTagValid;

		// Token: 0x0403A303 RID: 238339
		[Token(Token = "0x403A303")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0403A304 RID: 238340
		[Token(Token = "0x403A304")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A305 RID: 238341
		[Token(Token = "0x403A305")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403A306 RID: 238342
		[Token(Token = "0x403A306")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
