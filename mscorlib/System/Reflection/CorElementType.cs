using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000527 RID: 1319
	[Token(Token = "0x2000527")]
	[System.Serializable]
	internal enum CorElementType : byte
	{
		// Token: 0x04001579 RID: 5497
		[Token(Token = "0x4001579")]
		End,
		// Token: 0x0400157A RID: 5498
		[Token(Token = "0x400157A")]
		Void,
		// Token: 0x0400157B RID: 5499
		[Token(Token = "0x400157B")]
		Boolean,
		// Token: 0x0400157C RID: 5500
		[Token(Token = "0x400157C")]
		Char,
		// Token: 0x0400157D RID: 5501
		[Token(Token = "0x400157D")]
		I1,
		// Token: 0x0400157E RID: 5502
		[Token(Token = "0x400157E")]
		U1,
		// Token: 0x0400157F RID: 5503
		[Token(Token = "0x400157F")]
		I2,
		// Token: 0x04001580 RID: 5504
		[Token(Token = "0x4001580")]
		U2,
		// Token: 0x04001581 RID: 5505
		[Token(Token = "0x4001581")]
		I4,
		// Token: 0x04001582 RID: 5506
		[Token(Token = "0x4001582")]
		U4,
		// Token: 0x04001583 RID: 5507
		[Token(Token = "0x4001583")]
		I8,
		// Token: 0x04001584 RID: 5508
		[Token(Token = "0x4001584")]
		U8,
		// Token: 0x04001585 RID: 5509
		[Token(Token = "0x4001585")]
		R4,
		// Token: 0x04001586 RID: 5510
		[Token(Token = "0x4001586")]
		R8,
		// Token: 0x04001587 RID: 5511
		[Token(Token = "0x4001587")]
		String,
		// Token: 0x04001588 RID: 5512
		[Token(Token = "0x4001588")]
		Ptr,
		// Token: 0x04001589 RID: 5513
		[Token(Token = "0x4001589")]
		ByRef,
		// Token: 0x0400158A RID: 5514
		[Token(Token = "0x400158A")]
		ValueType,
		// Token: 0x0400158B RID: 5515
		[Token(Token = "0x400158B")]
		Class,
		// Token: 0x0400158C RID: 5516
		[Token(Token = "0x400158C")]
		Var,
		// Token: 0x0400158D RID: 5517
		[Token(Token = "0x400158D")]
		Array,
		// Token: 0x0400158E RID: 5518
		[Token(Token = "0x400158E")]
		GenericInst,
		// Token: 0x0400158F RID: 5519
		[Token(Token = "0x400158F")]
		TypedByRef,
		// Token: 0x04001590 RID: 5520
		[Token(Token = "0x4001590")]
		I = 24,
		// Token: 0x04001591 RID: 5521
		[Token(Token = "0x4001591")]
		U,
		// Token: 0x04001592 RID: 5522
		[Token(Token = "0x4001592")]
		FnPtr = 27,
		// Token: 0x04001593 RID: 5523
		[Token(Token = "0x4001593")]
		Object,
		// Token: 0x04001594 RID: 5524
		[Token(Token = "0x4001594")]
		SzArray,
		// Token: 0x04001595 RID: 5525
		[Token(Token = "0x4001595")]
		MVar,
		// Token: 0x04001596 RID: 5526
		[Token(Token = "0x4001596")]
		CModReqd,
		// Token: 0x04001597 RID: 5527
		[Token(Token = "0x4001597")]
		CModOpt,
		// Token: 0x04001598 RID: 5528
		[Token(Token = "0x4001598")]
		Internal,
		// Token: 0x04001599 RID: 5529
		[Token(Token = "0x4001599")]
		Max,
		// Token: 0x0400159A RID: 5530
		[Token(Token = "0x400159A")]
		Modifier = 64,
		// Token: 0x0400159B RID: 5531
		[Token(Token = "0x400159B")]
		Sentinel,
		// Token: 0x0400159C RID: 5532
		[Token(Token = "0x400159C")]
		Pinned = 69,
		// Token: 0x0400159D RID: 5533
		[Token(Token = "0x400159D")]
		ELEMENT_TYPE_END = 0,
		// Token: 0x0400159E RID: 5534
		[Token(Token = "0x400159E")]
		ELEMENT_TYPE_VOID,
		// Token: 0x0400159F RID: 5535
		[Token(Token = "0x400159F")]
		ELEMENT_TYPE_BOOLEAN,
		// Token: 0x040015A0 RID: 5536
		[Token(Token = "0x40015A0")]
		ELEMENT_TYPE_CHAR,
		// Token: 0x040015A1 RID: 5537
		[Token(Token = "0x40015A1")]
		ELEMENT_TYPE_I1,
		// Token: 0x040015A2 RID: 5538
		[Token(Token = "0x40015A2")]
		ELEMENT_TYPE_U1,
		// Token: 0x040015A3 RID: 5539
		[Token(Token = "0x40015A3")]
		ELEMENT_TYPE_I2,
		// Token: 0x040015A4 RID: 5540
		[Token(Token = "0x40015A4")]
		ELEMENT_TYPE_U2,
		// Token: 0x040015A5 RID: 5541
		[Token(Token = "0x40015A5")]
		ELEMENT_TYPE_I4,
		// Token: 0x040015A6 RID: 5542
		[Token(Token = "0x40015A6")]
		ELEMENT_TYPE_U4,
		// Token: 0x040015A7 RID: 5543
		[Token(Token = "0x40015A7")]
		ELEMENT_TYPE_I8,
		// Token: 0x040015A8 RID: 5544
		[Token(Token = "0x40015A8")]
		ELEMENT_TYPE_U8,
		// Token: 0x040015A9 RID: 5545
		[Token(Token = "0x40015A9")]
		ELEMENT_TYPE_R4,
		// Token: 0x040015AA RID: 5546
		[Token(Token = "0x40015AA")]
		ELEMENT_TYPE_R8,
		// Token: 0x040015AB RID: 5547
		[Token(Token = "0x40015AB")]
		ELEMENT_TYPE_STRING,
		// Token: 0x040015AC RID: 5548
		[Token(Token = "0x40015AC")]
		ELEMENT_TYPE_PTR,
		// Token: 0x040015AD RID: 5549
		[Token(Token = "0x40015AD")]
		ELEMENT_TYPE_BYREF,
		// Token: 0x040015AE RID: 5550
		[Token(Token = "0x40015AE")]
		ELEMENT_TYPE_VALUETYPE,
		// Token: 0x040015AF RID: 5551
		[Token(Token = "0x40015AF")]
		ELEMENT_TYPE_CLASS,
		// Token: 0x040015B0 RID: 5552
		[Token(Token = "0x40015B0")]
		ELEMENT_TYPE_VAR,
		// Token: 0x040015B1 RID: 5553
		[Token(Token = "0x40015B1")]
		ELEMENT_TYPE_ARRAY,
		// Token: 0x040015B2 RID: 5554
		[Token(Token = "0x40015B2")]
		ELEMENT_TYPE_GENERICINST,
		// Token: 0x040015B3 RID: 5555
		[Token(Token = "0x40015B3")]
		ELEMENT_TYPE_TYPEDBYREF,
		// Token: 0x040015B4 RID: 5556
		[Token(Token = "0x40015B4")]
		ELEMENT_TYPE_I = 24,
		// Token: 0x040015B5 RID: 5557
		[Token(Token = "0x40015B5")]
		ELEMENT_TYPE_U,
		// Token: 0x040015B6 RID: 5558
		[Token(Token = "0x40015B6")]
		ELEMENT_TYPE_FNPTR = 27,
		// Token: 0x040015B7 RID: 5559
		[Token(Token = "0x40015B7")]
		ELEMENT_TYPE_OBJECT,
		// Token: 0x040015B8 RID: 5560
		[Token(Token = "0x40015B8")]
		ELEMENT_TYPE_SZARRAY,
		// Token: 0x040015B9 RID: 5561
		[Token(Token = "0x40015B9")]
		ELEMENT_TYPE_MVAR,
		// Token: 0x040015BA RID: 5562
		[Token(Token = "0x40015BA")]
		ELEMENT_TYPE_CMOD_REQD,
		// Token: 0x040015BB RID: 5563
		[Token(Token = "0x40015BB")]
		ELEMENT_TYPE_CMOD_OPT,
		// Token: 0x040015BC RID: 5564
		[Token(Token = "0x40015BC")]
		ELEMENT_TYPE_INTERNAL,
		// Token: 0x040015BD RID: 5565
		[Token(Token = "0x40015BD")]
		ELEMENT_TYPE_MAX,
		// Token: 0x040015BE RID: 5566
		[Token(Token = "0x40015BE")]
		ELEMENT_TYPE_MODIFIER = 64,
		// Token: 0x040015BF RID: 5567
		[Token(Token = "0x40015BF")]
		ELEMENT_TYPE_SENTINEL,
		// Token: 0x040015C0 RID: 5568
		[Token(Token = "0x40015C0")]
		ELEMENT_TYPE_PINNED = 69
	}
}
