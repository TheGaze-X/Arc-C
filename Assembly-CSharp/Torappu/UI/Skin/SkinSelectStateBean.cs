using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EEC RID: 16108
	[Token(Token = "0x2003EEC")]
	public class SkinSelectStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x06018FCA RID: 102346 RVA: 0x0009C870 File Offset: 0x0009AA70
		// (set) Token: 0x06018FCB RID: 102347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B90")]
		public bool isCheckingSpDynIllust
		{
			[Token(Token = "0x6018FCA")]
			[Address(RVA = "0x11A2F90", Offset = "0x11A1B90", VA = "0x1811A2F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FCB")]
			[Address(RVA = "0x11A2FF0", Offset = "0x11A1BF0", VA = "0x1811A2FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x06018FCC RID: 102348 RVA: 0x0009C888 File Offset: 0x0009AA88
		[Token(Token = "0x17003B91")]
		public int currentSelectIndex
		{
			[Token(Token = "0x6018FCC")]
			[Address(RVA = "0x11A2F30", Offset = "0x11A1B30", VA = "0x1811A2F30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x06018FCD RID: 102349 RVA: 0x0009C8A0 File Offset: 0x0009AAA0
		[Token(Token = "0x17003B92")]
		public CharUISkinStruct currentCharUISkinStruct
		{
			[Token(Token = "0x6018FCD")]
			[Address(RVA = "0x11A2D70", Offset = "0x11A1970", VA = "0x1811A2D70")]
			get
			{
				return default(CharUISkinStruct);
			}
		}

		// Token: 0x06018FCE RID: 102350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FCE")]
		[Address(RVA = "0x11A27C0", Offset = "0x11A13C0", VA = "0x1811A27C0")]
		public void RefreshData()
		{
		}

		// Token: 0x06018FCF RID: 102351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FCF")]
		[Address(RVA = "0x11A2910", Offset = "0x11A1510", VA = "0x1811A2910")]
		public void SwitchSelectIndex(int index)
		{
		}

		// Token: 0x06018FD0 RID: 102352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FD0")]
		[Address(RVA = "0x11A2890", Offset = "0x11A1490", VA = "0x1811A2890")]
		public void SwitchIsCheckingSpDynIllust(bool isCheckingSpDynIllust)
		{
		}

		// Token: 0x06018FD1 RID: 102353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FD1")]
		[Address(RVA = "0x11A2BC0", Offset = "0x11A17C0", VA = "0x1811A2BC0")]
		private void _ResetContext(int index, SkinSelectViewModel nextViewModel)
		{
		}

		// Token: 0x06018FD2 RID: 102354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FD2")]
		[Address(RVA = "0x11A2A60", Offset = "0x11A1660", VA = "0x1811A2A60")]
		private void _RefreshItemShowingSpDynIllust()
		{
		}

		// Token: 0x06018FD3 RID: 102355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FD3")]
		[Address(RVA = "0x11A2CB0", Offset = "0x11A18B0", VA = "0x1811A2CB0")]
		public SkinSelectStateBean()
		{
		}

		// Token: 0x0401EE01 RID: 126465
		[Token(Token = "0x401EE01")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<SkinSelectViewModel> viewModelList;

		// Token: 0x0401EE02 RID: 126466
		[Token(Token = "0x401EE02")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public SkinSelectViewModel selectViewModel;

		// Token: 0x0401EE03 RID: 126467
		[Token(Token = "0x401EE03")]
		[FieldOffset(Offset = "0x28")]
		private int m_currentSelectIndex;

		// Token: 0x0401EE05 RID: 126469
		[Token(Token = "0x401EE05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCheckingSpDynIllust;

		// Token: 0x0401EE06 RID: 126470
		[Token(Token = "0x401EE06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isCheckingSpDynIllust;

		// Token: 0x0401EE07 RID: 126471
		[Token(Token = "0x401EE07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentSelectIndex;

		// Token: 0x0401EE08 RID: 126472
		[Token(Token = "0x401EE08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currentCharUISkinStruct;

		// Token: 0x0401EE09 RID: 126473
		[Token(Token = "0x401EE09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401EE0A RID: 126474
		[Token(Token = "0x401EE0A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SwitchSelectIndex;

		// Token: 0x0401EE0B RID: 126475
		[Token(Token = "0x401EE0B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SwitchIsCheckingSpDynIllust;

		// Token: 0x0401EE0C RID: 126476
		[Token(Token = "0x401EE0C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetContext;

		// Token: 0x0401EE0D RID: 126477
		[Token(Token = "0x401EE0D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshItemShowingSpDynIllust;

		// Token: 0x0401EE0E RID: 126478
		[Token(Token = "0x401EE0E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
