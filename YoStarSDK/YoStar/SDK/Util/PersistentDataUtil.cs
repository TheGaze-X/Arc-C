using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public class PersistentDataUtil
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public static PersistentDataUtil Instance
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x5C13AA0", Offset = "0x5C126A0", VA = "0x185C13AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x5C11250", Offset = "0x5C0FE50", VA = "0x185C11250")]
		private string FileName(PersistentDataUtil.StorePathType type, string area = "")
		{
			return null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x5C113A0", Offset = "0x5C0FFA0", VA = "0x185C113A0")]
		private string GetFilePath(PersistentDataUtil.StorePathType type, string area)
		{
			return null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x5C114B0", Offset = "0x5C100B0", VA = "0x185C114B0")]
		private void Log(string msg)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x5C13360", Offset = "0x5C11F60", VA = "0x185C13360")]
		private Dictionary<string, object> WriteToMemory(PersistentDataUtil.StorePathType type, string area, string key, object value)
		{
			return null;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x5C12410", Offset = "0x5C11010", VA = "0x185C12410")]
		private Dictionary<string, object> ReadFromMemory(PersistentDataUtil.StorePathType type, string area)
		{
			return null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x5C10B80", Offset = "0x5C0F780", VA = "0x185C10B80")]
		private Dictionary<string, object> DeleteFromMemory(PersistentDataUtil.StorePathType type, string area, string key)
		{
			return null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		private T GetValueFromDic<T>(Dictionary<string, object> originDic, string area, string key, T defaultValue)
		{
			return null;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x5C12650", Offset = "0x5C11250", VA = "0x185C12650")]
		private Dictionary<string, object> SetValueToDic(Dictionary<string, object> originDic, string area, string key, object value)
		{
			return null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x5C10D70", Offset = "0x5C0F970", VA = "0x185C10D70")]
		private Dictionary<string, object> DeleteInDicByKey(Dictionary<string, object> originDic, string area, string key)
		{
			return null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x5C13580", Offset = "0x5C12180", VA = "0x185C13580")]
		private void WriteToPlayerPrefs(PersistentDataUtil.StorePathType type, string area, Dictionary<string, object> data)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x5C124F0", Offset = "0x5C110F0", VA = "0x185C124F0")]
		private Dictionary<string, object> ReadFromPlayerPrefs(PersistentDataUtil.StorePathType type, string area)
		{
			return null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x5C12B90", Offset = "0x5C11790", VA = "0x185C12B90")]
		private void WriteToFile(PersistentDataUtil.StorePathType type, string area, Dictionary<string, object> data)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x5C11560", Offset = "0x5C10160", VA = "0x185C11560")]
		private Dictionary<string, object> ReadFromFile(PersistentDataUtil.StorePathType type, string area)
		{
			return null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x5C13780", Offset = "0x5C12380", VA = "0x185C13780")]
		private void Write(PersistentDataUtil.StorePathType type, string area, string key, object value)
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x5C12870", Offset = "0x5C11470", VA = "0x185C12870")]
		public void UpdateCachePreInit()
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x5C13670", Offset = "0x5C12270", VA = "0x185C13670")]
		public void WriteUserInfo(string key, object value)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x5C12AF0", Offset = "0x5C116F0", VA = "0x185C12AF0")]
		public void WriteInitInfo(string key, object value)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x5C12A80", Offset = "0x5C11680", VA = "0x185C12A80")]
		public void WriteCommonInfo(string key, object value)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048F")]
		private T Read<T>(PersistentDataUtil.StorePathType type, string area, string key, T defaultValue)
		{
			return null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		public T ReadUserInfo<T>(string key, T defaultValue)
		{
			return null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		public T ReadInitInfo<T>(string key, T defaultValue)
		{
			return null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		public T ReadCommonInfo<T>(string key, T defaultValue)
		{
			return null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x5C10F90", Offset = "0x5C0FB90", VA = "0x185C10F90")]
		private void Delete(PersistentDataUtil.StorePathType type, string area, string key)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x5C111C0", Offset = "0x5C0FDC0", VA = "0x185C111C0")]
		public void DeletedUserInfo(string key)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x5C11130", Offset = "0x5C0FD30", VA = "0x185C11130")]
		public void DeletedInitInfo(string key)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x5C110D0", Offset = "0x5C0FCD0", VA = "0x185C110D0")]
		public void DeletedCommonInfo(string key)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x5C12820", Offset = "0x5C11420", VA = "0x185C12820")]
		public void StoreDeviceID(string deviceID)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x5C11460", Offset = "0x5C10060", VA = "0x185C11460")]
		public string GetStoredDeviceID()
		{
			return null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x5C10B40", Offset = "0x5C0F740", VA = "0x185C10B40")]
		public void DeleteDeviceID()
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x5C11340", Offset = "0x5C0FF40", VA = "0x185C11340")]
		private string GetArea()
		{
			return null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x5C139B0", Offset = "0x5C125B0", VA = "0x185C139B0")]
		public PersistentDataUtil()
		{
		}

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x0")]
		private static PersistentDataUtil _instance;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		private const string FILENAME_FORMAT = "YoSDK_{0}_{1}";

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object _lockObject;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object _fileAccessLock;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, object> _userInfoDic;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, object> _initInfoDic;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, object> _commonInfoDic;

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		private enum StorePathType
		{
			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			UserInfo,
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			InitInfo,
			// Token: 0x04000294 RID: 660
			[Token(Token = "0x4000294")]
			CommonInfo
		}
	}
}
