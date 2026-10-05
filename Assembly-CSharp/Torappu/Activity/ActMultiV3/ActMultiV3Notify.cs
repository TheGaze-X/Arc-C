using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EFB RID: 28411
	[Token(Token = "0x2006EFB")]
	public class ActMultiV3Notify : UINotifyView<ActMultiV3Notify.Param>
	{
		// Token: 0x060285D8 RID: 165336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285D8")]
		[Address(RVA = "0x23BAAA0", Offset = "0x23B96A0", VA = "0x1823BAAA0", Slot = "9")]
		protected override void Render(ActMultiV3Notify.Param param)
		{
		}

		// Token: 0x060285D9 RID: 165337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285D9")]
		[Address(RVA = "0x23BAB70", Offset = "0x23B9770", VA = "0x1823BAB70")]
		public ActMultiV3Notify()
		{
		}

		// Token: 0x04039634 RID: 235060
		[Token(Token = "0x4039634")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNotify;

		// Token: 0x04039635 RID: 235061
		[Token(Token = "0x4039635")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039636 RID: 235062
		[Token(Token = "0x4039636")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006EFC RID: 28412
		[Token(Token = "0x2006EFC")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060285DA RID: 165338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60285DA")]
			[Address(RVA = "0x23BC9F0", Offset = "0x23BB5F0", VA = "0x1823BC9F0", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x060285DB RID: 165339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285DB")]
			[Address(RVA = "0x1535180", Offset = "0x1533D80", VA = "0x181535180")]
			public Param()
			{
			}

			// Token: 0x04039637 RID: 235063
			[Token(Token = "0x4039637")]
			[FieldOffset(Offset = "0x10")]
			public string notifyTips;

			// Token: 0x04039638 RID: 235064
			[Token(Token = "0x4039638")]
			[FieldOffset(Offset = "0x18")]
			public bool useDeduplicate;
		}
	}
}
