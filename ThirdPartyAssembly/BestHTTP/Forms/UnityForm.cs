using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BestHTTP.Forms
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	public sealed class UnityForm : HTTPFormBase
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EE")]
		public WWWForm Form
		{
			[Token(Token = "0x6002910")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002911")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnityForm()
		{
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x5180570", Offset = "0x517F170", VA = "0x185180570")]
		public UnityForm(WWWForm form)
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x53B04A0", Offset = "0x53AF0A0", VA = "0x1853B04A0", Slot = "4")]
		public override void CopyFrom(HTTPFormBase fields)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x53B0650", Offset = "0x53AF250", VA = "0x1853B0650", Slot = "5")]
		public override void PrepareRequest(HTTPRequest request)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x53B0630", Offset = "0x53AF230", VA = "0x1853B0630", Slot = "6")]
		public override byte[] GetData()
		{
			return null;
		}
	}
}
