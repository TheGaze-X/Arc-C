using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Security.Claims
{
	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	[System.Serializable]
	public class Claim
	{
		// Token: 0x06001C1B RID: 7195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x4B536F0", Offset = "0x4B522F0", VA = "0x184B536F0")]
		public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x4B53AB0", Offset = "0x4B526B0", VA = "0x184B53AB0")]
		internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x4B53740", Offset = "0x4B52340", VA = "0x184B53740")]
		protected Claim(Claim other, ClaimsIdentity subject)
		{
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x4B53600", Offset = "0x4B52200", VA = "0x184B53600")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000327")]
		public System.Collections.Generic.IDictionary<string, string> Properties
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x4B53DA0", Offset = "0x4B529A0", VA = "0x184B53DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000328")]
		public ClaimsIdentity Subject
		{
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			internal set
			{
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000329")]
		public string Type
		{
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700032A")]
		public string Value
		{
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x4B53590", Offset = "0x4B52190", VA = "0x184B53590", Slot = "4")]
		public virtual Claim Clone(ClaimsIdentity identity)
		{
			return null;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x4B53670", Offset = "0x4B52270", VA = "0x184B53670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x10")]
		private string m_issuer;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x18")]
		private string m_originalIssuer;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x20")]
		private string m_type;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x28")]
		private string m_value;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x30")]
		private string m_valueType;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x38")]
		[System.NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x40")]
		private System.Collections.Generic.Dictionary<string, string> m_properties;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x48")]
		[System.NonSerialized]
		private object m_propertyLock;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x50")]
		[System.NonSerialized]
		private ClaimsIdentity m_subject;
	}
}
