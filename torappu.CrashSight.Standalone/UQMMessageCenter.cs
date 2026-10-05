using System;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using UnityEngine;

namespace GCloud.UQM
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class UQMMessageCenter : MonoBehaviour
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x55AA4C0", Offset = "0x55A90C0", VA = "0x1855AA4C0")]
		[MonoPInvokeCallback(typeof(UQMMessageCenter.UQMRetJsonEventHandler))]
		public static string OnUQMRet(int methodId, int crashType, int logUploadResult)
		{
			return null;
		}

		// Token: 0x060000F7 RID: 247
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x55AAB90", Offset = "0x55A9790", VA = "0x1855AAB90")]
		[PreserveSig]
		private static extern void cs_setUnityCallback(UQMMessageCenter.UQMRetJsonEventHandler eventHandler);

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x17000007")]
		public static UQMMessageCenter Instance
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x55AAC20", Offset = "0x55A9820", VA = "0x1855AAC20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x55AA320", Offset = "0x55A8F20", VA = "0x1855AA320")]
		public void Init()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x55AAB30", Offset = "0x55A9730", VA = "0x1855AAB30")]
		public void Uninit()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x55AA8D0", Offset = "0x55A94D0", VA = "0x1855AA8D0")]
		private static string SynchronousDelegate(object arg)
		{
			return null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UQMMessageCenter()
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool initialzed;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static UQMMessageCenter instance;

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000FE RID: 254
		[Token(Token = "0x2000016")]
		private delegate string UQMRetJsonEventHandler(int methodId, int callType, int logUploadResult);
	}
}
