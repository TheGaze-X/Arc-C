using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UDatasdk.commons;
using UnityEngine;

namespace UDatasdk
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	internal class UDataManager : IUDataSDK
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x55C6350", Offset = "0x55C4F50", VA = "0x1855C6350")]
		private UDataManager()
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700000A")]
		public static UDataManager Instance
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x55C63D0", Offset = "0x55C4FD0", VA = "0x1855C63D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x55C59E0", Offset = "0x55C45E0", VA = "0x1855C59E0", Slot = "4")]
		public void InitUData(string channel, string pid, string evn, bool logEnable, [Optional] Action<InitRet> callBack)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x55C5DD0", Offset = "0x55C49D0", VA = "0x1855C5DD0", Slot = "5")]
		public void TrackEvent(string eventType, string eventProperty)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x55C5820", Offset = "0x55C4420", VA = "0x1855C5820", Slot = "6")]
		public void DeleteAllCache()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x55C5CF0", Offset = "0x55C48F0", VA = "0x1855C5CF0", Slot = "7")]
		public void OnResume()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x55C5C80", Offset = "0x55C4880", VA = "0x1855C5C80", Slot = "8")]
		public void OnPause()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x55C5BE0", Offset = "0x55C47E0", VA = "0x1855C5BE0", Slot = "9")]
		public void OnApplicationQuit()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x55C5930", Offset = "0x55C4530", VA = "0x1855C5930")]
		private void HandleLog(string logString, string stackTrace, LogType type)
		{
		}

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CoreComponent coreComponent;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UDataSdkData uDataSdkData;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UDataManager m_instance;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TimeSynchronizer timeSynchronizer;
	}
}
