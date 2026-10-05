using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA6 RID: 31398
	[Token(Token = "0x2007AA6")]
	public class Act12sideEntryZoneGroupView : DataBinder<Act12sideZoneDescGroupViewProperty>
	{
		// Token: 0x17006719 RID: 26393
		// (get) Token: 0x0602BFC2 RID: 180162 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFC3 RID: 180163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006719")]
		public Action<string> onZoneClick
		{
			[Token(Token = "0x602BFC2")]
			[Address(RVA = "0x27D9850", Offset = "0x27D8450", VA = "0x1827D9850")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BFC3")]
			[Address(RVA = "0x27D98B0", Offset = "0x27D84B0", VA = "0x1827D98B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BFC4 RID: 180164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFC4")]
		[Address(RVA = "0x27D95E0", Offset = "0x27D81E0", VA = "0x1827D95E0", Slot = "7")]
		public override void OnValueChanged(Act12sideZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x0602BFC5 RID: 180165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFC5")]
		[Address(RVA = "0x27D97E0", Offset = "0x27D83E0", VA = "0x1827D97E0")]
		public Act12sideEntryZoneGroupView()
		{
		}

		// Token: 0x0403FB62 RID: 260962
		[Token(Token = "0x403FB62")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act12sideEntryZoneView[] _zoneViewList;

		// Token: 0x0403FB64 RID: 260964
		[Token(Token = "0x403FB64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onZoneClick;

		// Token: 0x0403FB65 RID: 260965
		[Token(Token = "0x403FB65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onZoneClick;

		// Token: 0x0403FB66 RID: 260966
		[Token(Token = "0x403FB66")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403FB67 RID: 260967
		[Token(Token = "0x403FB67")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
