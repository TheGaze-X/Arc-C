using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C95 RID: 19605
	[Token(Token = "0x2004C95")]
	public class OpenServerV2MainViewModel : IHotfixable
	{
		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x0601D61F RID: 120351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044EF")]
		public OpenServerV2ChainLoginViewModel chainLoginViewModel
		{
			[Token(Token = "0x601D61F")]
			[Address(RVA = "0x16EFA00", Offset = "0x16EE600", VA = "0x1816EFA00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x0601D620 RID: 120352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044F0")]
		public OpenServerV2MissionViewModel missionViewModel
		{
			[Token(Token = "0x601D620")]
			[Address(RVA = "0x16EFA60", Offset = "0x16EE660", VA = "0x1816EFA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x0601D621 RID: 120353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044F1")]
		public OpenServerV2TotalCheckinViewModel totalCheckinViewModel
		{
			[Token(Token = "0x601D621")]
			[Address(RVA = "0x16EFAC0", Offset = "0x16EE6C0", VA = "0x1816EFAC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D622 RID: 120354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D622")]
		[Address(RVA = "0x16EF380", Offset = "0x16EDF80", VA = "0x1816EF380")]
		public void LoadData()
		{
		}

		// Token: 0x0601D623 RID: 120355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D623")]
		[Address(RVA = "0x16EF5F0", Offset = "0x16EE1F0", VA = "0x1816EF5F0")]
		public void UpdateData()
		{
		}

		// Token: 0x0601D624 RID: 120356 RVA: 0x000AB4F8 File Offset: 0x000A96F8
		[Token(Token = "0x601D624")]
		[Address(RVA = "0x16EF1F0", Offset = "0x16EDDF0", VA = "0x1816EF1F0")]
		public bool CheckIfFuncTypeAvailable(OpenServerFuncType funcType)
		{
			return default(bool);
		}

		// Token: 0x0601D625 RID: 120357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D625")]
		[Address(RVA = "0x16EF680", Offset = "0x16EE280", VA = "0x1816EF680")]
		public OpenServerV2MainViewModel()
		{
		}

		// Token: 0x04026AEA RID: 158442
		[Token(Token = "0x4026AEA")]
		[FieldOffset(Offset = "0x10")]
		private OpenServerV2ChainLoginViewModel m_chainLoginViewModel;

		// Token: 0x04026AEB RID: 158443
		[Token(Token = "0x4026AEB")]
		[FieldOffset(Offset = "0x18")]
		private OpenServerV2MissionViewModel m_missionViewModel;

		// Token: 0x04026AEC RID: 158444
		[Token(Token = "0x4026AEC")]
		[FieldOffset(Offset = "0x20")]
		private OpenServerV2TotalCheckinViewModel m_totalCheckinViewModel;

		// Token: 0x04026AED RID: 158445
		[Token(Token = "0x4026AED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chainLoginViewModel;

		// Token: 0x04026AEE RID: 158446
		[Token(Token = "0x4026AEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_missionViewModel;

		// Token: 0x04026AEF RID: 158447
		[Token(Token = "0x4026AEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalCheckinViewModel;

		// Token: 0x04026AF0 RID: 158448
		[Token(Token = "0x4026AF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026AF1 RID: 158449
		[Token(Token = "0x4026AF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04026AF2 RID: 158450
		[Token(Token = "0x4026AF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfFuncTypeAvailable;

		// Token: 0x04026AF3 RID: 158451
		[Token(Token = "0x4026AF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
