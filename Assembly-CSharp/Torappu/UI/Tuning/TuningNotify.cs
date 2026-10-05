using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CC4 RID: 15556
	[Token(Token = "0x2003CC4")]
	public class TuningNotify : UINotifyView<TuningNotify.Param>
	{
		// Token: 0x06018413 RID: 99347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018413")]
		[Address(RVA = "0x10C33A0", Offset = "0x10C1FA0", VA = "0x1810C33A0", Slot = "9")]
		protected override void Render(TuningNotify.Param param)
		{
		}

		// Token: 0x06018414 RID: 99348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018414")]
		[Address(RVA = "0x10C3470", Offset = "0x10C2070", VA = "0x1810C3470")]
		public TuningNotify()
		{
		}

		// Token: 0x0401D969 RID: 121193
		[Token(Token = "0x401D969")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNotify;

		// Token: 0x0401D96A RID: 121194
		[Token(Token = "0x401D96A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D96B RID: 121195
		[Token(Token = "0x401D96B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CC5 RID: 15557
		[Token(Token = "0x2003CC5")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06018415 RID: 99349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018415")]
			[Address(RVA = "0x10BB7F0", Offset = "0x10BA3F0", VA = "0x1810BB7F0", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x06018416 RID: 99350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018416")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0401D96C RID: 121196
			[Token(Token = "0x401D96C")]
			[FieldOffset(Offset = "0x10")]
			public string notifyTips;

			// Token: 0x0401D96D RID: 121197
			[Token(Token = "0x401D96D")]
			[FieldOffset(Offset = "0x18")]
			public bool isStrongAlert;
		}
	}
}
