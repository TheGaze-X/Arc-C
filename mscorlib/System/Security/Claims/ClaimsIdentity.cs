using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using Il2CppDummyDll;

namespace System.Security.Claims
{
	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ClaimsIdentity : System.Security.Principal.IIdentity
	{
		// Token: 0x06001C26 RID: 7206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x4B55960", Offset = "0x4B54560", VA = "0x184B55960")]
		public ClaimsIdentity()
		{
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x4B55930", Offset = "0x4B54530", VA = "0x184B55930")]
		public ClaimsIdentity(System.Collections.Generic.IEnumerable<Claim> claims)
		{
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x4B56210", Offset = "0x4B54E10", VA = "0x184B56210")]
		public ClaimsIdentity(System.Security.Principal.IIdentity identity, System.Collections.Generic.IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
		{
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x4B55B70", Offset = "0x4B54770", VA = "0x184B55B70")]
		internal ClaimsIdentity(System.Security.Principal.IIdentity identity, System.Collections.Generic.IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
		{
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x4B56240", Offset = "0x4B54E40", VA = "0x184B56240")]
		protected ClaimsIdentity(ClaimsIdentity other)
		{
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0x4B55990", Offset = "0x4B54590", VA = "0x184B55990")]
		protected ClaimsIdentity(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700032B")]
		public virtual string AuthenticationType
		{
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032C")]
		public ClaimsIdentity Actor
		{
			[Token(Token = "0x6001C2D")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C2E")]
			[Address(RVA = "0x4B565D0", Offset = "0x4B551D0", VA = "0x184B565D0")]
			set
			{
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700032D")]
		public virtual System.Collections.Generic.IEnumerable<Claim> Claims
		{
			[Token(Token = "0x6001C2F")]
			[Address(RVA = "0x4B564F0", Offset = "0x4B550F0", VA = "0x184B564F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700032E")]
		public virtual string Name
		{
			[Token(Token = "0x6001C30")]
			[Address(RVA = "0x4B56570", Offset = "0x4B55170", VA = "0x184B56570", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700032F")]
		public string NameClaimType
		{
			[Token(Token = "0x6001C31")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x4B53FB0", Offset = "0x4B52BB0", VA = "0x184B53FB0", Slot = "9")]
		public virtual ClaimsIdentity Clone()
		{
			return null;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x4B53EB0", Offset = "0x4B52AB0", VA = "0x184B53EB0", Slot = "10")]
		public virtual void AddClaim(Claim claim)
		{
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x4B55520", Offset = "0x4B54120", VA = "0x184B55520")]
		private void SafeAddClaims(System.Collections.Generic.IEnumerable<Claim> claims)
		{
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x4B55470", Offset = "0x4B54070", VA = "0x184B55470")]
		private void SafeAddClaim(Claim claim)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x4B54AE0", Offset = "0x4B536E0", VA = "0x184B54AE0", Slot = "11")]
		public virtual Claim FindFirst(string type)
		{
			return null;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x4B553F0", Offset = "0x4B53FF0", VA = "0x184B553F0")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializingMethod(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x4B55210", Offset = "0x4B53E10", VA = "0x184B55210")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C39")]
		[Address(RVA = "0x4B55300", Offset = "0x4B53F00", VA = "0x184B55300")]
		[System.Runtime.Serialization.OnDeserializing]
		private void OnDeserializingMethod(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x4B54CE0", Offset = "0x4B538E0", VA = "0x184B54CE0", Slot = "12")]
		protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x4B54160", Offset = "0x4B52D60", VA = "0x184B54160")]
		private void DeserializeClaims(string serializedClaims)
		{
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x4B55750", Offset = "0x4B54350", VA = "0x184B55750")]
		private string SerializeClaims()
		{
			return null;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x000128B8 File Offset: 0x00010AB8
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x4B551C0", Offset = "0x4B53DC0", VA = "0x184B551C0")]
		private bool IsCircular(ClaimsIdentity subject)
		{
			return default(bool);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x4B54490", Offset = "0x4B53090", VA = "0x184B54490")]
		private void Deserialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool useContext)
		{
		}

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[System.NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.NonSerialized]
		private System.Collections.Generic.List<Claim> m_instanceClaims;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private System.Collections.ObjectModel.Collection<System.Collections.Generic.IEnumerable<Claim>> m_externalClaims;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[System.NonSerialized]
		private string m_nameType;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[System.NonSerialized]
		private string m_roleType;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_version;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private ClaimsIdentity m_actor;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_authenticationType;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private object m_bootstrapContext;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_label;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_serializedNameType;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_serializedRoleType;

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_serializedClaims;
	}
}
