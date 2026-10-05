using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B70 RID: 31600
	[Token(Token = "0x2007B70")]
	public abstract class fsDirectConverter<TModel> : fsDirectConverter
	{
		// Token: 0x170067A2 RID: 26530
		// (get) Token: 0x0602C3A4 RID: 181156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067A2")]
		public override Type ModelType
		{
			[Token(Token = "0x602C3A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C3A5 RID: 181157 RVA: 0x000DE8A0 File Offset: 0x000DCAA0
		[Token(Token = "0x602C3A5")]
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3A6 RID: 181158 RVA: 0x000DE8B8 File Offset: 0x000DCAB8
		[Token(Token = "0x602C3A6")]
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3A7 RID: 181159
		[Token(Token = "0x602C3A7")]
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);

		// Token: 0x0602C3A8 RID: 181160
		[Token(Token = "0x602C3A8")]
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);

		// Token: 0x0602C3A9 RID: 181161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3A9")]
		protected fsDirectConverter()
		{
		}
	}
}
