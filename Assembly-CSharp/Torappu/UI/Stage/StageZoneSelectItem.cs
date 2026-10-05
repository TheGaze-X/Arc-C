using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006994 RID: 27028
	[Token(Token = "0x2006994")]
	public abstract class StageZoneSelectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026AC1 RID: 158401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AC1")]
		[Address(RVA = "0x21CEB20", Offset = "0x21CD720", VA = "0x1821CEB20")]
		public void EventOnZoneClick()
		{
		}

		// Token: 0x17005B50 RID: 23376
		// (get) Token: 0x06026AC2 RID: 158402 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026AC3 RID: 158403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B50")]
		public Action<string> onZoneClick
		{
			[Token(Token = "0x6026AC2")]
			[Address(RVA = "0x21CEE40", Offset = "0x21CDA40", VA = "0x1821CEE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026AC3")]
			[Address(RVA = "0x21CEF60", Offset = "0x21CDB60", VA = "0x1821CEF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005B51 RID: 23377
		// (get) Token: 0x06026AC4 RID: 158404 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026AC5 RID: 158405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B51")]
		public string zoneId
		{
			[Token(Token = "0x6026AC4")]
			[Address(RVA = "0x21CEF00", Offset = "0x21CDB00", VA = "0x1821CEF00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026AC5")]
			[Address(RVA = "0x21CF060", Offset = "0x21CDC60", VA = "0x1821CF060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005B52 RID: 23378
		// (get) Token: 0x06026AC6 RID: 158406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026AC7 RID: 158407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B52")]
		public ZoneViewModel viewModel
		{
			[Token(Token = "0x6026AC6")]
			[Address(RVA = "0x21CEEA0", Offset = "0x21CDAA0", VA = "0x1821CEEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026AC7")]
			[Address(RVA = "0x21CEFE0", Offset = "0x21CDBE0", VA = "0x1821CEFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026AC8 RID: 158408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AC8")]
		[Address(RVA = "0x21CEC80", Offset = "0x21CD880", VA = "0x1821CEC80")]
		public void Render(ZoneViewModel zoneModel)
		{
		}

		// Token: 0x06026AC9 RID: 158409
		[Token(Token = "0x6026AC9")]
		protected abstract void OnRender(ZoneViewModel viewModel);

		// Token: 0x06026ACA RID: 158410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ACA")]
		[Address(RVA = "0x21CEDE0", Offset = "0x21CD9E0", VA = "0x1821CEDE0")]
		protected StageZoneSelectItem()
		{
		}

		// Token: 0x04036987 RID: 223623
		[Token(Token = "0x4036987")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnZoneClick;

		// Token: 0x04036988 RID: 223624
		[Token(Token = "0x4036988")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onZoneClick;

		// Token: 0x04036989 RID: 223625
		[Token(Token = "0x4036989")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onZoneClick;

		// Token: 0x0403698A RID: 223626
		[Token(Token = "0x403698A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403698B RID: 223627
		[Token(Token = "0x403698B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_zoneId;

		// Token: 0x0403698C RID: 223628
		[Token(Token = "0x403698C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x0403698D RID: 223629
		[Token(Token = "0x403698D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_viewModel;

		// Token: 0x0403698E RID: 223630
		[Token(Token = "0x403698E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403698F RID: 223631
		[Token(Token = "0x403698F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
