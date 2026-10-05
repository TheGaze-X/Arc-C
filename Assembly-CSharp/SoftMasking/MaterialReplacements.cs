using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace SoftMasking
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	internal class MaterialReplacements
	{
		// Token: 0x0600495C RID: 18780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495C")]
		[Address(RVA = "0x1578490", Offset = "0x1577090", VA = "0x181578490")]
		public MaterialReplacements(IMaterialReplacer replacer, Action<Material> applyParameters)
		{
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600495D")]
		[Address(RVA = "0x1578120", Offset = "0x1576D20", VA = "0x181578120")]
		public Material Get(Material original)
		{
			return null;
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495E")]
		[Address(RVA = "0x1578350", Offset = "0x1576F50", VA = "0x181578350")]
		public void Release(Material replacement)
		{
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x1577F30", Offset = "0x1576B30", VA = "0x181577F30")]
		public void ApplyAll()
		{
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x1578020", Offset = "0x1576C20", VA = "0x181578020")]
		public void DestroyAllAndClear()
		{
		}

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x10")]
		private readonly IMaterialReplacer _replacer;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action<Material> _applyParameters;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<MaterialReplacements.MaterialOverride> _overrides;

		// Token: 0x02000433 RID: 1075
		[Token(Token = "0x2000433")]
		private class MaterialOverride
		{
			// Token: 0x06004961 RID: 18785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004961")]
			[Address(RVA = "0x1577ED0", Offset = "0x1576AD0", VA = "0x181577ED0")]
			public MaterialOverride(Material original, Material replacement)
			{
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06004962 RID: 18786 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004963 RID: 18787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000161")]
			public Material original
			{
				[Token(Token = "0x6004962")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004963")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x06004964 RID: 18788 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004965 RID: 18789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000162")]
			public Material replacement
			{
				[Token(Token = "0x6004964")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004965")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06004966 RID: 18790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004966")]
			[Address(RVA = "0x1577EB0", Offset = "0x1576AB0", VA = "0x181577EB0")]
			public Material Get()
			{
				return null;
			}

			// Token: 0x06004967 RID: 18791 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
			[Token(Token = "0x6004967")]
			[Address(RVA = "0x1577EC0", Offset = "0x1576AC0", VA = "0x181577EC0")]
			public bool Release()
			{
				return default(bool);
			}

			// Token: 0x04000DFC RID: 3580
			[Token(Token = "0x4000DFC")]
			[FieldOffset(Offset = "0x10")]
			private int _useCount;
		}
	}
}
