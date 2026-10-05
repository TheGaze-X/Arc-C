using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007185 RID: 29061
	[Token(Token = "0x2007185")]
	public class Act9D0NewsStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170061A3 RID: 24995
		// (get) Token: 0x06029402 RID: 168962 RVA: 0x000D4DD8 File Offset: 0x000D2FD8
		// (set) Token: 0x06029403 RID: 168963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061A3")]
		public int unReadNewsCount
		{
			[Token(Token = "0x6029402")]
			[Address(RVA = "0x249F1D0", Offset = "0x249DDD0", VA = "0x18249F1D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6029403")]
			[Address(RVA = "0x249F2A0", Offset = "0x249DEA0", VA = "0x18249F2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061A4 RID: 24996
		// (get) Token: 0x06029404 RID: 168964 RVA: 0x000D4DF0 File Offset: 0x000D2FF0
		// (set) Token: 0x06029405 RID: 168965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061A4")]
		public int unLockedCount
		{
			[Token(Token = "0x6029404")]
			[Address(RVA = "0x249F170", Offset = "0x249DD70", VA = "0x18249F170")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6029405")]
			[Address(RVA = "0x249F230", Offset = "0x249DE30", VA = "0x18249F230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06029406 RID: 168966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029406")]
		[Address(RVA = "0x249E770", Offset = "0x249D370", VA = "0x18249E770")]
		public void LoadData()
		{
		}

		// Token: 0x06029407 RID: 168967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029407")]
		[Address(RVA = "0x249EDC0", Offset = "0x249D9C0", VA = "0x18249EDC0")]
		public void UpdateNewsStatus(string newsId)
		{
		}

		// Token: 0x06029408 RID: 168968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029408")]
		[Address(RVA = "0x249F060", Offset = "0x249DC60", VA = "0x18249F060")]
		public Act9D0NewsViewModel getViewModel(string newsId)
		{
			return null;
		}

		// Token: 0x06029409 RID: 168969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029409")]
		[Address(RVA = "0x249EFB0", Offset = "0x249DBB0", VA = "0x18249EFB0")]
		public Act9D0NewsStateBean()
		{
		}

		// Token: 0x0403AEAA RID: 241322
		[Token(Token = "0x403AEAA")]
		[FieldOffset(Offset = "0x10")]
		public List<Act9D0NewsViewModel> newsModelList;

		// Token: 0x0403AEAD RID: 241325
		[Token(Token = "0x403AEAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_unReadNewsCount;

		// Token: 0x0403AEAE RID: 241326
		[Token(Token = "0x403AEAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_unReadNewsCount;

		// Token: 0x0403AEAF RID: 241327
		[Token(Token = "0x403AEAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_unLockedCount;

		// Token: 0x0403AEB0 RID: 241328
		[Token(Token = "0x403AEB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_unLockedCount;

		// Token: 0x0403AEB1 RID: 241329
		[Token(Token = "0x403AEB1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AEB2 RID: 241330
		[Token(Token = "0x403AEB2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateNewsStatus;

		// Token: 0x0403AEB3 RID: 241331
		[Token(Token = "0x403AEB3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_getViewModel;

		// Token: 0x0403AEB4 RID: 241332
		[Token(Token = "0x403AEB4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
