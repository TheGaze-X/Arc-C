using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F52 RID: 28498
	[Token(Token = "0x2006F52")]
	public class ActMultiV3ManualStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06028791 RID: 165777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028791")]
		[Address(RVA = "0x23C3FE0", Offset = "0x23C2BE0", VA = "0x1823C3FE0")]
		public void InitData(string actId)
		{
		}

		// Token: 0x06028792 RID: 165778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028792")]
		[Address(RVA = "0x23C41B0", Offset = "0x23C2DB0", VA = "0x1823C41B0")]
		public void LoadData()
		{
		}

		// Token: 0x06028793 RID: 165779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028793")]
		[Address(RVA = "0x23C42B0", Offset = "0x23C2EB0", VA = "0x1823C42B0")]
		public ActMultiV3ManualStateBean()
		{
		}

		// Token: 0x04039916 RID: 235798
		[Token(Token = "0x4039916")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3ManualProperty property;

		// Token: 0x04039917 RID: 235799
		[Token(Token = "0x4039917")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3ManualPhotoSelectStateBean.Input input;

		// Token: 0x04039918 RID: 235800
		[Token(Token = "0x4039918")]
		[FieldOffset(Offset = "0x20")]
		public HashSet<string> tempIdSet;

		// Token: 0x04039919 RID: 235801
		[Token(Token = "0x4039919")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403991A RID: 235802
		[Token(Token = "0x403991A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403991B RID: 235803
		[Token(Token = "0x403991B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
