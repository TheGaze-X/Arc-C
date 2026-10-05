using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ADF RID: 27359
	[Token(Token = "0x2006ADF")]
	public class ArchiveAchievementDataBinder : DataBinder<ArchiveAchievementProperty>
	{
		// Token: 0x17005C80 RID: 23680
		// (get) Token: 0x0602721D RID: 160285 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602721E RID: 160286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C80")]
		public ArchiveAchievementController controller
		{
			[Token(Token = "0x602721D")]
			[Address(RVA = "0x224F510", Offset = "0x224E110", VA = "0x18224F510")]
			get
			{
				return null;
			}
			[Token(Token = "0x602721E")]
			[Address(RVA = "0x224F570", Offset = "0x224E170", VA = "0x18224F570")]
			set
			{
			}
		}

		// Token: 0x0602721F RID: 160287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602721F")]
		[Address(RVA = "0x224EDC0", Offset = "0x224D9C0", VA = "0x18224EDC0", Slot = "7")]
		public override void OnValueChanged(ArchiveAchievementProperty property)
		{
		}

		// Token: 0x06027220 RID: 160288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027220")]
		[Address(RVA = "0x224F180", Offset = "0x224DD80", VA = "0x18224F180")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027221 RID: 160289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027221")]
		[Address(RVA = "0x224F4A0", Offset = "0x224E0A0", VA = "0x18224F4A0")]
		public ArchiveAchievementDataBinder()
		{
		}

		// Token: 0x040375A2 RID: 226722
		[Token(Token = "0x40375A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveAchievementItemAdapter _adapter;

		// Token: 0x040375A3 RID: 226723
		[Token(Token = "0x40375A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggleListWhetherEmpty;

		// Token: 0x040375A4 RID: 226724
		[Token(Token = "0x40375A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _filters;

		// Token: 0x040375A5 RID: 226725
		[Token(Token = "0x40375A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ArchiveAchievementRarityCountView> _rarityCountViews;

		// Token: 0x040375A6 RID: 226726
		[Token(Token = "0x40375A6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveAchievementGotFilterView _gotFilterView;

		// Token: 0x040375A7 RID: 226727
		[Token(Token = "0x40375A7")]
		[FieldOffset(Offset = "0x48")]
		private List<IArchiveAchievementListFilterView> m_filters;

		// Token: 0x040375A8 RID: 226728
		[Token(Token = "0x40375A8")]
		[FieldOffset(Offset = "0x50")]
		private ArchiveAchievementController m_controller;

		// Token: 0x040375A9 RID: 226729
		[Token(Token = "0x40375A9")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x040375AA RID: 226730
		[Token(Token = "0x40375AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040375AB RID: 226731
		[Token(Token = "0x40375AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040375AC RID: 226732
		[Token(Token = "0x40375AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040375AD RID: 226733
		[Token(Token = "0x40375AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040375AE RID: 226734
		[Token(Token = "0x40375AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
