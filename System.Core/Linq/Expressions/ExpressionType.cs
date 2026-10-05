using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public enum ExpressionType
	{
		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		Add,
		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		AddChecked,
		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		And,
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		AndAlso,
		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		ArrayLength,
		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		ArrayIndex,
		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		Call,
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		Coalesce,
		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		Conditional,
		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		Constant,
		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		Convert,
		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		ConvertChecked,
		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		Divide,
		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		Equal,
		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		ExclusiveOr,
		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		GreaterThan,
		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		GreaterThanOrEqual,
		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		Invoke,
		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		Lambda,
		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		LeftShift,
		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		LessThan,
		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		LessThanOrEqual,
		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		ListInit,
		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		MemberAccess,
		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		MemberInit,
		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		Modulo,
		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		Multiply,
		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		MultiplyChecked,
		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		Negate,
		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		UnaryPlus,
		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		NegateChecked,
		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		New,
		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		NewArrayInit,
		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		NewArrayBounds,
		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		Not,
		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		NotEqual,
		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		Or,
		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		OrElse,
		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		Parameter,
		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		Power,
		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		Quote,
		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		RightShift,
		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		Subtract,
		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		SubtractChecked,
		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		TypeAs,
		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		TypeIs,
		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		Assign,
		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		Block,
		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		DebugInfo,
		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		Decrement,
		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		Dynamic,
		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		Default,
		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		Extension,
		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		Goto,
		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		Increment,
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		Index,
		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		Label,
		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		RuntimeVariables,
		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		Loop,
		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		Switch,
		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		Throw,
		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		Try,
		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		Unbox,
		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		AddAssign,
		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		AndAssign,
		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		DivideAssign,
		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		ExclusiveOrAssign,
		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		LeftShiftAssign,
		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		ModuloAssign,
		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		MultiplyAssign,
		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		OrAssign,
		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		PowerAssign,
		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		RightShiftAssign,
		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		SubtractAssign,
		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		AddAssignChecked,
		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		MultiplyAssignChecked,
		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		SubtractAssignChecked,
		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		PreIncrementAssign,
		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		PreDecrementAssign,
		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		PostIncrementAssign,
		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		PostDecrementAssign,
		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		TypeEqual,
		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		OnesComplement,
		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		IsTrue,
		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		IsFalse
	}
}
