using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace SoftMasking
{
	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2000438")]
	public class MaterialReplacerChain : IMaterialReplacer
	{
		// Token: 0x06004977 RID: 18807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004977")]
		[Address(RVA = "0x1578870", Offset = "0x1577470", VA = "0x181578870")]
		public MaterialReplacerChain(IEnumerable<IMaterialReplacer> replacers, IMaterialReplacer yetAnother)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x0002C160 File Offset: 0x0002A360
		// (set) Token: 0x06004979 RID: 18809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000165")]
		public int order
		{
			[Token(Token = "0x6004978")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004979")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497A")]
		[Address(RVA = "0x1578760", Offset = "0x1577360", VA = "0x181578760", Slot = "5")]
		public Material Replace(Material material)
		{
			return null;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600497B")]
		[Address(RVA = "0x1578550", Offset = "0x1577150", VA = "0x181578550")]
		private void Initialize()
		{
		}

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<IMaterialReplacer> _replacers;
	}
}
