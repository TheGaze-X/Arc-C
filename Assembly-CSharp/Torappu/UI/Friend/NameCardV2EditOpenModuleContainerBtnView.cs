using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E08 RID: 19976
	[Token(Token = "0x2004E08")]
	public class NameCardV2EditOpenModuleContainerBtnView : DataBinder<NameCardV2Property>
	{
		// Token: 0x0601DDA3 RID: 122275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDA3")]
		[Address(RVA = "0x1774C80", Offset = "0x1773880", VA = "0x181774C80", Slot = "7")]
		public override void OnValueChanged(NameCardV2Property property)
		{
		}

		// Token: 0x0601DDA4 RID: 122276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDA4")]
		[Address(RVA = "0x1774DB0", Offset = "0x17739B0", VA = "0x181774DB0")]
		public void OpenModuleContainer()
		{
		}

		// Token: 0x0601DDA5 RID: 122277 RVA: 0x000AC878 File Offset: 0x000AAA78
		[Token(Token = "0x601DDA5")]
		[Address(RVA = "0x1774E80", Offset = "0x1773A80", VA = "0x181774E80")]
		private static bool _CheckEditAddBtnTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601DDA6 RID: 122278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDA6")]
		[Address(RVA = "0x1774F10", Offset = "0x1773B10", VA = "0x181774F10")]
		public NameCardV2EditOpenModuleContainerBtnView()
		{
		}

		// Token: 0x04027909 RID: 162057
		[Token(Token = "0x4027909")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _editAddNameCardBtnTrackPoint;

		// Token: 0x0402790A RID: 162058
		[Token(Token = "0x402790A")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402790B RID: 162059
		[Token(Token = "0x402790B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402790C RID: 162060
		[Token(Token = "0x402790C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenModuleContainer;

		// Token: 0x0402790D RID: 162061
		[Token(Token = "0x402790D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckEditAddBtnTrackPoint;

		// Token: 0x0402790E RID: 162062
		[Token(Token = "0x402790E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
