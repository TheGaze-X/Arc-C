using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000290")]
		public Object unityObjectArgument
		{
			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000291")]
		public string unityObjectArgumentAssemblyTypeName
		{
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x17000292")]
		public int intArgument
		{
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x5958CC0", Offset = "0x59578C0", VA = "0x185958CC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x17000293")]
		public float floatArgument
		{
			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x5958CB0", Offset = "0x59578B0", VA = "0x185958CB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000294")]
		public string stringArgument
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x5911BD0", Offset = "0x59107D0", VA = "0x185911BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x17000295")]
		public bool boolArgument
		{
			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x5958CA0", Offset = "0x59578A0", VA = "0x185958CA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x5958C70", Offset = "0x5957870", VA = "0x185958C70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x5958C70", Offset = "0x5957870", VA = "0x185958C70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArgumentCache()
		{
		}

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("objectArgument")]
		private Object m_ObjectArgument;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		private string m_ObjectArgumentAssemblyTypeName;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("intArgument")]
		private int m_IntArgument;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("floatArgument")]
		[SerializeField]
		private float m_FloatArgument;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("stringArgument")]
		private string m_StringArgument;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_BoolArgument;
	}
}
