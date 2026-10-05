using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000270")]
	public abstract class UxmlAttributeDescription
	{
		// Token: 0x0600117C RID: 4476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x5B2D000", Offset = "0x5B2BC00", VA = "0x185B2D000")]
		protected UxmlAttributeDescription()
		{
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046C")]
		public string name
		{
			[Token(Token = "0x600117D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600117E")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046D")]
		public IEnumerable<string> obsoleteNames
		{
			[Token(Token = "0x600117F")]
			[Address(RVA = "0x5B2D030", Offset = "0x5B2BC30", VA = "0x185B2D030")]
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046E")]
		protected string type
		{
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046F")]
		protected string typeNamespace
		{
			[Token(Token = "0x6001181")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000470 RID: 1136
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000470")]
		public UxmlAttributeDescription.Use use
		{
			[Token(Token = "0x6001182")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000471 RID: 1137
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000471")]
		public UxmlTypeRestriction restriction
		{
			[Token(Token = "0x6001183")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x5B2CBA0", Offset = "0x5B2B7A0", VA = "0x185B2CBA0")]
		internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value)
		{
			return default(bool);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x6001185")]
		protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value)
		{
			return default(bool);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001186")]
		protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue)
		{
			return null;
		}

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x18")]
		private string[] m_ObsoleteNames;

		// Token: 0x02000271 RID: 625
		[Token(Token = "0x2000271")]
		public enum Use
		{
			// Token: 0x0400091F RID: 2335
			[Token(Token = "0x400091F")]
			None,
			// Token: 0x04000920 RID: 2336
			[Token(Token = "0x4000920")]
			Optional,
			// Token: 0x04000921 RID: 2337
			[Token(Token = "0x4000921")]
			Prohibited,
			// Token: 0x04000922 RID: 2338
			[Token(Token = "0x4000922")]
			Required
		}
	}
}
