using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.FlatBuffers
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public class FlatBufferBuilder
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x5448DE0", Offset = "0x54479E0", VA = "0x185448DE0")]
		public FlatBufferBuilder(int initialSize)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x5449010", Offset = "0x5447C10", VA = "0x185449010")]
		public FlatBufferBuilder(ByteBuffer buffer)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x5446E00", Offset = "0x5445A00", VA = "0x185446E00")]
		public void Clear()
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000042A8 File Offset: 0x000024A8
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000093")]
		public bool ForceDefaults
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x150B0D0", Offset = "0x1509CD0", VA = "0x18150B0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x17000094")]
		public int Offset
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x54490D0", Offset = "0x5447CD0", VA = "0x1854490D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x5448250", Offset = "0x5446E50", VA = "0x185448250")]
		public void Pad(int size)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x54480E0", Offset = "0x5446CE0", VA = "0x1854480E0")]
		private void GrowBuffer()
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x5448320", Offset = "0x5446F20", VA = "0x185448320")]
		public void Prep(int size, int additionalBytes)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x54484C0", Offset = "0x54470C0", VA = "0x1854484C0")]
		public void PutBool(bool x)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x5448790", Offset = "0x5447390", VA = "0x185448790")]
		public void PutSbyte(sbyte x)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x54484F0", Offset = "0x54470F0", VA = "0x1854484F0")]
		public void PutByte(byte x)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x5448840", Offset = "0x5447440", VA = "0x185448840")]
		public void PutShort(short x)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x5448980", Offset = "0x5447580", VA = "0x185448980")]
		public void PutUshort(ushort x)
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x54486C0", Offset = "0x54472C0", VA = "0x1854486C0")]
		public void PutInt(int x)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x54488E0", Offset = "0x54474E0", VA = "0x1854488E0")]
		public void PutUint(uint x)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x54486F0", Offset = "0x54472F0", VA = "0x1854486F0")]
		public void PutLong(long x)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x54486F0", Offset = "0x54472F0", VA = "0x1854486F0")]
		public void PutUlong(ulong x)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x5448610", Offset = "0x5447210", VA = "0x185448610")]
		public void PutFloat(float x)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054F")]
		public void Put<T>(T[] x) where T : struct
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000550")]
		public void Put<T>(ArraySegment<T> x) where T : struct
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000551")]
		public void Put<T>(IntPtr ptr, int sizeInBytes) where T : struct
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x5448520", Offset = "0x5447120", VA = "0x185448520")]
		public void PutDouble(double x)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x5445D00", Offset = "0x5444900", VA = "0x185445D00")]
		public void AddBool(bool x)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x5446740", Offset = "0x5445340", VA = "0x185446740")]
		public void AddSbyte(sbyte x)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x5445E50", Offset = "0x5444A50", VA = "0x185445E50")]
		public void AddByte(byte x)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x5446920", Offset = "0x5445520", VA = "0x185446920")]
		public void AddShort(short x)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x5446C70", Offset = "0x5445870", VA = "0x185446C70")]
		public void AddUshort(ushort x)
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x54463F0", Offset = "0x5444FF0", VA = "0x1854463F0")]
		public void AddInt(int x)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x5446B40", Offset = "0x5445740", VA = "0x185446B40")]
		public void AddUint(uint x)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x5446500", Offset = "0x5445100", VA = "0x185446500")]
		public void AddLong(long x)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x5446500", Offset = "0x5445100", VA = "0x185446500")]
		public void AddUlong(ulong x)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x5446130", Offset = "0x5444D30", VA = "0x185446130")]
		public void AddFloat(float x)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055D")]
		public void Add<T>(T[] x) where T : struct
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055E")]
		public void Add<T>(ArraySegment<T> x) where T : struct
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055F")]
		public void Add<T>(IntPtr ptr, int sizeInBytes) where T : struct
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x5445F60", Offset = "0x5444B60", VA = "0x185445F60")]
		public void AddDouble(double x)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x5446600", Offset = "0x5445200", VA = "0x185446600")]
		public void AddOffset(int off)
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x5448D30", Offset = "0x5447930", VA = "0x185448D30")]
		public void StartVector(int elemSize, int count, int alignment)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x5447910", Offset = "0x5446510", VA = "0x185447910")]
		public VectorOffset EndVector()
		{
			return default(VectorOffset);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x6000564")]
		public VectorOffset CreateVectorOfTables<T>(Offset<T>[] offsets) where T : struct
		{
			return default(VectorOffset);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5448150", Offset = "0x5446D50", VA = "0x185448150")]
		public void Nested(int obj)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x54481E0", Offset = "0x5446DE0", VA = "0x1854481E0")]
		public void NotNested()
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x5448C30", Offset = "0x5447830", VA = "0x185448C30")]
		public void StartTable(int numfields)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x5448B80", Offset = "0x5447780", VA = "0x185448B80")]
		public void Slot(int voffset)
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x5445D50", Offset = "0x5444950", VA = "0x185445D50")]
		public void AddBool(int o, bool x, bool d)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x5445C40", Offset = "0x5444840", VA = "0x185445C40")]
		public void AddBool(int o, bool? x)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x5446800", Offset = "0x5445400", VA = "0x185446800")]
		public void AddSbyte(int o, sbyte x, sbyte d)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x54466C0", Offset = "0x54452C0", VA = "0x1854466C0")]
		public void AddSbyte(int o, sbyte? x)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x5445DD0", Offset = "0x54449D0", VA = "0x185445DD0")]
		public void AddByte(int o, byte x, byte d)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x5445EA0", Offset = "0x5444AA0", VA = "0x185445EA0")]
		public void AddByte(int o, byte? x)
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x54468D0", Offset = "0x54454D0", VA = "0x1854468D0")]
		public void AddShort(int o, short x, int d)
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x5446850", Offset = "0x5445450", VA = "0x185446850")]
		public void AddShort(int o, short? x)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x5446D30", Offset = "0x5445930", VA = "0x185446D30")]
		public void AddUshort(int o, ushort x, ushort d)
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x5446D80", Offset = "0x5445980", VA = "0x185446D80")]
		public void AddUshort(int o, ushort? x)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x54462C0", Offset = "0x5444EC0", VA = "0x1854462C0")]
		public void AddInt(int o, int x, int d)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x5446340", Offset = "0x5444F40", VA = "0x185446340")]
		public void AddInt(int o, int? x)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x5446A80", Offset = "0x5445680", VA = "0x185446A80")]
		public void AddUint(int o, uint x, uint d)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x5446AC0", Offset = "0x54456C0", VA = "0x185446AC0")]
		public void AddUint(int o, uint? x)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x5446440", Offset = "0x5445040", VA = "0x185446440")]
		public void AddLong(int o, long x, long d)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x5446480", Offset = "0x5445080", VA = "0x185446480")]
		public void AddLong(int o, long? x)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x5446440", Offset = "0x5445040", VA = "0x185446440")]
		public void AddUlong(int o, ulong x, ulong d)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x5446BF0", Offset = "0x54457F0", VA = "0x185446BF0")]
		public void AddUlong(int o, ulong? x)
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x5446270", Offset = "0x5444E70", VA = "0x185446270")]
		public void AddFloat(int o, float x, double d)
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x54461F0", Offset = "0x5444DF0", VA = "0x1854461F0")]
		public void AddFloat(int o, float? x)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x5446070", Offset = "0x5444C70", VA = "0x185446070")]
		public void AddDouble(int o, double x, double d)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x54460B0", Offset = "0x5444CB0", VA = "0x1854460B0")]
		public void AddDouble(int o, double? x)
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x54465C0", Offset = "0x54451C0", VA = "0x1854465C0")]
		public void AddOffset(int o, int x, int d)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x5447000", Offset = "0x5445C00", VA = "0x185447000")]
		public StringOffset CreateString(string s)
		{
			return default(StringOffset);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x5446EC0", Offset = "0x5445AC0", VA = "0x185446EC0")]
		public StringOffset CreateSharedString(string s)
		{
			return default(StringOffset);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x54469E0", Offset = "0x54455E0", VA = "0x1854469E0")]
		public void AddStruct(int voffset, int x, int d)
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x5447270", Offset = "0x5445E70", VA = "0x185447270")]
		public int EndTable()
		{
			return 0;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x5448A20", Offset = "0x5447620", VA = "0x185448A20")]
		public void Required(int table, int field)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x5447FB0", Offset = "0x5446BB0", VA = "0x185447FB0")]
		protected void Finish(int rootTable, bool sizePrefix)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x5448070", Offset = "0x5446C70", VA = "0x185448070")]
		public void Finish(int rootTable)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x5447960", Offset = "0x5446560", VA = "0x185447960")]
		public void FinishSizePrefixed(int rootTable)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public ByteBuffer DataBuffer
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x5448B20", Offset = "0x5447720", VA = "0x185448B20")]
		public byte[] SizedByteArray()
		{
			return null;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x5447A30", Offset = "0x5446630", VA = "0x185447A30")]
		protected void Finish(int rootTable, string fileIdentifier, bool sizePrefix)
		{
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x54480C0", Offset = "0x5446CC0", VA = "0x1854480C0")]
		public void Finish(int rootTable, string fileIdentifier)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x5447A10", Offset = "0x5446610", VA = "0x185447A10")]
		public void FinishSizePrefixed(int rootTable, string fileIdentifier)
		{
		}

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x10")]
		private int _space;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x18")]
		private ByteBuffer _bb;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x20")]
		private int _minAlign;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x28")]
		private int[] _vtable;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x30")]
		private int _vtableSize;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x34")]
		private int _objectStart;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x38")]
		private int[] _vtables;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x40")]
		private int _numVtables;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x44")]
		private int _vectorNumElems;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, StringOffset> _sharedStringMap;
	}
}
