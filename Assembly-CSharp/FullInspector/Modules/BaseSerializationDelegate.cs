using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Modules
{
	// Token: 0x02007C5B RID: 31835
	[Token(Token = "0x2007C5B")]
	public class BaseSerializationDelegate
	{
		// Token: 0x0602C7EC RID: 182252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7EC")]
		[Address(RVA = "0x2854540", Offset = "0x2853140", VA = "0x182854540")]
		public BaseSerializationDelegate()
		{
		}

		// Token: 0x0602C7ED RID: 182253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7ED")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public BaseSerializationDelegate(UnityEngine.Object methodContainer, string methodName)
		{
		}

		// Token: 0x17006824 RID: 26660
		// (get) Token: 0x0602C7EE RID: 182254 RVA: 0x000E0568 File Offset: 0x000DE768
		[Token(Token = "0x17006824")]
		public bool CanInvoke
		{
			[Token(Token = "0x602C7EE")]
			[Address(RVA = "0x28545B0", Offset = "0x28531B0", VA = "0x1828545B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C7EF RID: 182255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7EF")]
		[Address(RVA = "0x28542C0", Offset = "0x2852EC0", VA = "0x1828542C0")]
		protected object DoInvoke(params object[] parameters)
		{
			return null;
		}

		// Token: 0x04040329 RID: 262953
		[Token(Token = "0x4040329")]
		[FieldOffset(Offset = "0x10")]
		public UnityEngine.Object MethodContainer;

		// Token: 0x0404032A RID: 262954
		[Token(Token = "0x404032A")]
		[FieldOffset(Offset = "0x18")]
		public string MethodName;
	}
}
