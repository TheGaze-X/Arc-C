using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public class CriMonoBehaviourManager : MonoBehaviour
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700009E")]
		public static CriMonoBehaviourManager instance
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x3704010", Offset = "0x3702C10", VA = "0x183704010")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x3703710", Offset = "0x3702310", VA = "0x183703710")]
		public static void CreateInstance()
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x37037D0", Offset = "0x37023D0", VA = "0x1837037D0")]
		private static int GetIndex(CriMonoBehaviour criMonoBehaviour)
		{
			return 0;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x3703AA0", Offset = "0x37026A0", VA = "0x183703AA0")]
		public bool Register(CriMonoBehaviour criMonoBehaviour)
		{
			return default(bool);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x3703C40", Offset = "0x3702840", VA = "0x183703C40")]
		public static bool UnRegister(CriMonoBehaviour criMonoBehaviour)
		{
			return default(bool);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x3703610", Offset = "0x3702210", VA = "0x183703610")]
		private void Awake()
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x3703DA0", Offset = "0x37029A0", VA = "0x183703DA0")]
		private void Update()
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x37038F0", Offset = "0x37024F0", VA = "0x1837038F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CriMonoBehaviourManager()
		{
		}

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x0")]
		private static CriMonoBehaviourManager _instance;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x8")]
		private static List<CriMonoBehaviour> criMonoBehaviourList;
	}
}
