using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A1 RID: 9889
	[Token(Token = "0x20026A1")]
	[Serializable]
	public abstract class OperaNode : IHotfixable
	{
		// Token: 0x06010269 RID: 66153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010269")]
		[Address(RVA = "0x7ED4B0", Offset = "0x7EC0B0", VA = "0x1807ED4B0")]
		public void Execute()
		{
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x0601026A RID: 66154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700232A")]
		public object param
		{
			[Token(Token = "0x601026A")]
			[Address(RVA = "0x7ED5E0", Offset = "0x7EC1E0", VA = "0x1807ED5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0601026B RID: 66155
		[Token(Token = "0x1700232B")]
		public abstract CameraController.PostprocessMask postProcessType { [Token(Token = "0x601026B")] get; }

		// Token: 0x0601026C RID: 66156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601026C")]
		[Address(RVA = "0x7E40D0", Offset = "0x7E2CD0", VA = "0x1807E40D0", Slot = "5")]
		public virtual void OnCompleted()
		{
		}

		// Token: 0x0601026D RID: 66157
		[Token(Token = "0x601026D")]
		protected abstract void DoExecute();

		// Token: 0x0601026E RID: 66158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601026E")]
		[Address(RVA = "0x7ED580", Offset = "0x7EC180", VA = "0x1807ED580")]
		protected OperaNode()
		{
		}

		// Token: 0x04011FEB RID: 73707
		[Token(Token = "0x4011FEB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _preDelay;

		// Token: 0x04011FEC RID: 73708
		[Token(Token = "0x4011FEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x04011FED RID: 73709
		[Token(Token = "0x4011FED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x04011FEE RID: 73710
		[Token(Token = "0x4011FEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCompleted;

		// Token: 0x04011FEF RID: 73711
		[Token(Token = "0x4011FEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
