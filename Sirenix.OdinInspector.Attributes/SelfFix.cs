using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public struct SelfFix
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4E19FF0", Offset = "0x4E18BF0", VA = "0x184E19FF0")]
		public SelfFix(string name, Action action, bool offerInInspector)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4E19FF0", Offset = "0x4E18BF0", VA = "0x184E19FF0")]
		public SelfFix(string name, Delegate action, bool offerInInspector)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4E19F10", Offset = "0x4E18B10", VA = "0x184E19F10")]
		public static SelfFix Create(Action action, bool offerInInspector = true)
		{
			return default(SelfFix);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4E19F90", Offset = "0x4E18B90", VA = "0x184E19F90")]
		public static SelfFix Create(string title, Action action, bool offerInInspector = true)
		{
			return default(SelfFix);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60001C9")]
		public static SelfFix Create<T>(Action<T> action, bool offerInInspector = true) where T : new()
		{
			return default(SelfFix);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60001CA")]
		public static SelfFix Create<T>(string title, Action<T> action, bool offerInInspector = true) where T : new()
		{
			return default(SelfFix);
		}

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x0")]
		public string Title;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x8")]
		public Delegate Action;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x10")]
		public bool OfferInInspector;
	}
}
