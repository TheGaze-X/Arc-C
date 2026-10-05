using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CCE RID: 7374
	[Token(Token = "0x2001CCE")]
	public abstract class BuildingStationManageQueueBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x0600B692 RID: 46738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015E7")]
		protected SimpleLayoutContent charAvatarLayoutContent
		{
			[Token(Token = "0x600B692")]
			[Address(RVA = "0x3347050", Offset = "0x3345C50", VA = "0x183347050")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x0600B693 RID: 46739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015E8")]
		protected Image imgBkg
		{
			[Token(Token = "0x600B693")]
			[Address(RVA = "0x33470B0", Offset = "0x3345CB0", VA = "0x1833470B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600B694 RID: 46740
		[Token(Token = "0x170015E9")]
		protected abstract BuildingStationManageQueueBaseView.CharAdapter charAdapter { [Token(Token = "0x600B694")] get; }

		// Token: 0x0600B695 RID: 46741
		[Token(Token = "0x600B695")]
		protected abstract void InitAdapter();

		// Token: 0x0600B696 RID: 46742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B696")]
		[Address(RVA = "0x3346FF0", Offset = "0x3345BF0", VA = "0x183346FF0")]
		protected BuildingStationManageQueueBaseView()
		{
		}

		// Token: 0x0400B3EB RID: 46059
		[Token(Token = "0x400B3EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _charAvatarLayoutContent;

		// Token: 0x0400B3EC RID: 46060
		[Token(Token = "0x400B3EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0400B3ED RID: 46061
		[Token(Token = "0x400B3ED")]
		[FieldOffset(Offset = "0x28")]
		protected string slotId;

		// Token: 0x0400B3EE RID: 46062
		[Token(Token = "0x400B3EE")]
		[FieldOffset(Offset = "0x30")]
		protected StationCharStructModel[] chars;

		// Token: 0x0400B3EF RID: 46063
		[Token(Token = "0x400B3EF")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<BuildingCharModel, object> onCharClicked;

		// Token: 0x0400B3F0 RID: 46064
		[Token(Token = "0x400B3F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charAvatarLayoutContent;

		// Token: 0x0400B3F1 RID: 46065
		[Token(Token = "0x400B3F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_imgBkg;

		// Token: 0x0400B3F2 RID: 46066
		[Token(Token = "0x400B3F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CCF RID: 7375
		[Token(Token = "0x2001CCF")]
		protected abstract class CharAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B697 RID: 46743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B697")]
			[Address(RVA = "0x334BD30", Offset = "0x334A930", VA = "0x18334BD30")]
			protected CharAdapter()
			{
			}

			// Token: 0x0400B3F3 RID: 46067
			[Token(Token = "0x400B3F3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
