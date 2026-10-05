using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[ExcludeFromObjectFactory]
	[Serializable]
	public abstract class TextAsset : ScriptableObject
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public string version
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			internal set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000028")]
		public int instanceID
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x59F6D40", Offset = "0x59F5940", VA = "0x1859F6D40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public int hashCode
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x59F6D00", Offset = "0x59F5900", VA = "0x1859F6D00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public Material material
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public int materialHashCode
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x59F6D70", Offset = "0x59F5970", VA = "0x1859F6D70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			set
			{
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected TextAsset()
		{
		}

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal string m_Version;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x20")]
		internal int m_InstanceID;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x24")]
		internal int m_HashCode;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("material")]
		internal Material m_Material;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x30")]
		internal int m_MaterialHashCode;
	}
}
