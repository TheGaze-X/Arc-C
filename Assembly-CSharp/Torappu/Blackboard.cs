using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x02000ED5 RID: 3797
	[Token(Token = "0x2000ED5")]
	[LuaCallCSharp(GenFlag.No)]
	[Serializable]
	public class Blackboard : List<Blackboard.DataPair>, IHotfixable
	{
		// Token: 0x06006BB8 RID: 27576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB8")]
		[Address(RVA = "0x2005720", Offset = "0x2004320", VA = "0x182005720")]
		public Blackboard()
		{
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB9")]
		[Address(RVA = "0x2005660", Offset = "0x2004260", VA = "0x182005660")]
		public Blackboard(IList<Blackboard.DataPair> another)
		{
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBA")]
		[Address(RVA = "0x2005B30", Offset = "0x2004730", VA = "0x182005B30")]
		public Blackboard(IList<Blackboard.DataPair> another, float scale, IList<string> exceptKeys, bool isScaleDeltaToOne)
		{
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBB")]
		[Address(RVA = "0x20057B0", Offset = "0x20043B0", VA = "0x1820057B0")]
		public Blackboard(IList<Blackboard.DataPair> another, float scale, IList<string> certainKeys, bool isCertain, bool isScaleDeltaToOne)
		{
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0x2004AB0", Offset = "0x20036B0", VA = "0x182004AB0")]
		public void Reset(IList<Blackboard.DataPair> another)
		{
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0x2002D50", Offset = "0x2001950", VA = "0x182002D50")]
		public void Assign(IList<Blackboard.DataPair> another)
		{
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBE")]
		[Address(RVA = "0x2003350", Offset = "0x2001F50", VA = "0x182003350")]
		public void Assign(string key, float value)
		{
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBF")]
		[Address(RVA = "0x20049B0", Offset = "0x20035B0", VA = "0x1820049B0")]
		public void RemoveKey(string key)
		{
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC0")]
		[Address(RVA = "0x2002C90", Offset = "0x2001890", VA = "0x182002C90")]
		public void Assign(string key, FP value)
		{
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0x20031A0", Offset = "0x2001DA0", VA = "0x1820031A0")]
		public void Assign(string key, string value)
		{
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x00031458 File Offset: 0x0002F658
		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0x2003500", Offset = "0x2002100", VA = "0x182003500")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC3")]
		[Address(RVA = "0x2005290", Offset = "0x2003E90", VA = "0x182005290")]
		private void _AssignInternal(Blackboard.DataPair item)
		{
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC4")]
		[Address(RVA = "0x2004920", Offset = "0x2003520", VA = "0x182004920")]
		public static Blackboard Of(IList<Blackboard.DataPair> data)
		{
			return null;
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0x2004630", Offset = "0x2003230", VA = "0x182004630")]
		public static void MergeTo(ref Blackboard to, Blackboard from)
		{
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC6")]
		[Address(RVA = "0x20046F0", Offset = "0x20032F0", VA = "0x1820046F0")]
		public static void MergeTo(ref List<Blackboard.DataPair> to, List<Blackboard.DataPair> from)
		{
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC7")]
		[Address(RVA = "0x20051D0", Offset = "0x2003DD0", VA = "0x1820051D0")]
		public static Blackboard Union(Blackboard lhs, Blackboard rhs)
		{
			return null;
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x00031470 File Offset: 0x0002F670
		[Token(Token = "0x6006BC8")]
		[Address(RVA = "0x20040C0", Offset = "0x2002CC0", VA = "0x1820040C0")]
		public float GetFloat(string key)
		{
			return 0f;
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00031488 File Offset: 0x0002F688
		[Token(Token = "0x6006BC9")]
		[Address(RVA = "0x2003F00", Offset = "0x2002B00", VA = "0x182003F00")]
		public FP GetFP(string key)
		{
			return default(FP);
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x000314A0 File Offset: 0x0002F6A0
		[Token(Token = "0x6006BCA")]
		[Address(RVA = "0x20043C0", Offset = "0x2002FC0", VA = "0x1820043C0")]
		public int GetInt(string key)
		{
			return 0;
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x000314B8 File Offset: 0x0002F6B8
		[Token(Token = "0x6006BCB")]
		[Address(RVA = "0x2003E40", Offset = "0x2002A40", VA = "0x182003E40")]
		public bool GetBool(string key)
		{
			return default(bool);
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCC")]
		[Address(RVA = "0x2004540", Offset = "0x2003140", VA = "0x182004540")]
		public string GetString(string key)
		{
			return null;
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x000314D0 File Offset: 0x0002F6D0
		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0x2004D60", Offset = "0x2003960", VA = "0x182004D60")]
		public bool TryGetFloat(string key, out float value)
		{
			return default(bool);
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x000314E8 File Offset: 0x0002F6E8
		[Token(Token = "0x6006BCE")]
		[Address(RVA = "0x2004C70", Offset = "0x2003870", VA = "0x182004C70")]
		public bool TryGetFP(string key, out FP value)
		{
			return default(bool);
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00031500 File Offset: 0x0002F700
		[Token(Token = "0x6006BCF")]
		[Address(RVA = "0x2004E00", Offset = "0x2003A00", VA = "0x182004E00")]
		public bool TryGetInt(string key, out int value)
		{
			return default(bool);
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x00031518 File Offset: 0x0002F718
		[Token(Token = "0x6006BD0")]
		[Address(RVA = "0x2004B70", Offset = "0x2003770", VA = "0x182004B70")]
		public bool TryGetBool(string key, out bool value)
		{
			return default(bool);
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x00031530 File Offset: 0x0002F730
		[Token(Token = "0x6006BD1")]
		[Address(RVA = "0x2005040", Offset = "0x2003C40", VA = "0x182005040")]
		public bool TryGetString(string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x00031548 File Offset: 0x0002F748
		[Token(Token = "0x6006BD2")]
		[Address(RVA = "0x2004F10", Offset = "0x2003B10", VA = "0x182004F10")]
		public bool TryGetInternalData(string key, out Blackboard.DataPair data)
		{
			return default(bool);
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD3")]
		public TEnum GetEnumOrDefault<TEnum>(string key, string defaultStr) where TEnum : struct
		{
			return null;
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x00031560 File Offset: 0x0002F760
		[Token(Token = "0x6006BD4")]
		[Address(RVA = "0x2003FB0", Offset = "0x2002BB0", VA = "0x182003FB0")]
		public float GetFloatOrDefault(string key, float defaultValue, bool showWarning = true)
		{
			return 0f;
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x00031578 File Offset: 0x0002F778
		[Token(Token = "0x6006BD5")]
		[Address(RVA = "0x20041B0", Offset = "0x2002DB0", VA = "0x1820041B0")]
		public FP GetFpOrDefault(string key, FP defaultValue, bool showWarning = true)
		{
			return default(FP);
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x00031590 File Offset: 0x0002F790
		[Token(Token = "0x6006BD6")]
		[Address(RVA = "0x2003D80", Offset = "0x2002980", VA = "0x182003D80")]
		public bool GetBoolOrDefault(string key, bool defaultValue, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x000315A8 File Offset: 0x0002F7A8
		[Token(Token = "0x6006BD7")]
		[Address(RVA = "0x2004310", Offset = "0x2002F10", VA = "0x182004310")]
		public int GetIntOrDefault(string key, int defaultValue, bool showWarning = true)
		{
			return 0;
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD8")]
		[Address(RVA = "0x2004490", Offset = "0x2003090", VA = "0x182004490")]
		public string GetStringOrDefault(string key, string defaultValue, bool showWarning = true)
		{
			return null;
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x000315C0 File Offset: 0x0002F7C0
		[Token(Token = "0x6006BD9")]
		[Address(RVA = "0x20036A0", Offset = "0x20022A0", VA = "0x1820036A0")]
		public float EnsureFloat(string key)
		{
			return 0f;
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x000315D8 File Offset: 0x0002F7D8
		[Token(Token = "0x6006BDA")]
		[Address(RVA = "0x20035F0", Offset = "0x20021F0", VA = "0x1820035F0")]
		public bool EnsureBool(string key)
		{
			return default(bool);
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x000315F0 File Offset: 0x0002F7F0
		[Token(Token = "0x6006BDB")]
		[Address(RVA = "0x20037B0", Offset = "0x20023B0", VA = "0x1820037B0")]
		public int EnsureInt(string key)
		{
			return 0;
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDC")]
		[Address(RVA = "0x2003860", Offset = "0x2002460", VA = "0x182003860")]
		public string EnsureString(string key)
		{
			return null;
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDD")]
		[Address(RVA = "0x2003B10", Offset = "0x2002710", VA = "0x182003B10")]
		public void GenerateBlackboardWithPrefix(ref Blackboard blackboard, string prefix)
		{
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDE")]
		[Address(RVA = "0x2003940", Offset = "0x2002540", VA = "0x182003940")]
		public Blackboard GenerateBlackboardWithPrefix(string prefix)
		{
			return null;
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDF")]
		[Address(RVA = "0x20025D0", Offset = "0x20011D0", VA = "0x1820025D0")]
		public void AssignByPrefix(IList<Blackboard.DataPair> another, string prefixToStrip)
		{
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE0")]
		[Address(RVA = "0x2002910", Offset = "0x2001510", VA = "0x182002910")]
		public void AssignValueStrByPrefix(IList<Blackboard.DataPair> another, string prefixToStrip)
		{
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE1")]
		[Address(RVA = "0x2002350", Offset = "0x2000F50", VA = "0x182002350")]
		public void AddBlackboardStrictly(Blackboard other)
		{
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE2")]
		[Address(RVA = "0x20020B0", Offset = "0x2000CB0", VA = "0x1820020B0")]
		public void AddBlackboardBaseOneStrictly(Blackboard other)
		{
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x00031608 File Offset: 0x0002F808
		[Token(Token = "0x6006BE3")]
		[Address(RVA = "0x2005400", Offset = "0x2004000", VA = "0x182005400")]
		private bool _TryGetNumber(string key, out float value)
		{
			return default(bool);
		}

		// Token: 0x06006BE4 RID: 27620 RVA: 0x00031620 File Offset: 0x0002F820
		[Token(Token = "0x6006BE4")]
		[Address(RVA = "0x2005570", Offset = "0x2004170", VA = "0x182005570")]
		private bool _TryToStripPrefix(string key, string prefixToStrip, out string outKey)
		{
			return default(bool);
		}

		// Token: 0x04005051 RID: 20561
		[Token(Token = "0x4005051")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04005052 RID: 20562
		[Token(Token = "0x4005052")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04005053 RID: 20563
		[Token(Token = "0x4005053")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix2_ctor;

		// Token: 0x04005054 RID: 20564
		[Token(Token = "0x4005054")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix3_ctor;

		// Token: 0x04005055 RID: 20565
		[Token(Token = "0x4005055")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04005056 RID: 20566
		[Token(Token = "0x4005056")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Assign;

		// Token: 0x04005057 RID: 20567
		[Token(Token = "0x4005057")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_Assign;

		// Token: 0x04005058 RID: 20568
		[Token(Token = "0x4005058")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RemoveKey;

		// Token: 0x04005059 RID: 20569
		[Token(Token = "0x4005059")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix2_Assign;

		// Token: 0x0400505A RID: 20570
		[Token(Token = "0x400505A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix3_Assign;

		// Token: 0x0400505B RID: 20571
		[Token(Token = "0x400505B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ContainsKey;

		// Token: 0x0400505C RID: 20572
		[Token(Token = "0x400505C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AssignInternal;

		// Token: 0x0400505D RID: 20573
		[Token(Token = "0x400505D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Of;

		// Token: 0x0400505E RID: 20574
		[Token(Token = "0x400505E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_MergeTo;

		// Token: 0x0400505F RID: 20575
		[Token(Token = "0x400505F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_MergeTo;

		// Token: 0x04005060 RID: 20576
		[Token(Token = "0x4005060")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Union;

		// Token: 0x04005061 RID: 20577
		[Token(Token = "0x4005061")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetFloat;

		// Token: 0x04005062 RID: 20578
		[Token(Token = "0x4005062")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetFP;

		// Token: 0x04005063 RID: 20579
		[Token(Token = "0x4005063")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetInt;

		// Token: 0x04005064 RID: 20580
		[Token(Token = "0x4005064")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetBool;

		// Token: 0x04005065 RID: 20581
		[Token(Token = "0x4005065")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetString;

		// Token: 0x04005066 RID: 20582
		[Token(Token = "0x4005066")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryGetFloat;

		// Token: 0x04005067 RID: 20583
		[Token(Token = "0x4005067")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryGetFP;

		// Token: 0x04005068 RID: 20584
		[Token(Token = "0x4005068")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_TryGetInt;

		// Token: 0x04005069 RID: 20585
		[Token(Token = "0x4005069")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_TryGetBool;

		// Token: 0x0400506A RID: 20586
		[Token(Token = "0x400506A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TryGetString;

		// Token: 0x0400506B RID: 20587
		[Token(Token = "0x400506B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TryGetInternalData;

		// Token: 0x0400506C RID: 20588
		[Token(Token = "0x400506C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetEnumOrDefault;

		// Token: 0x0400506D RID: 20589
		[Token(Token = "0x400506D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetFloatOrDefault;

		// Token: 0x0400506E RID: 20590
		[Token(Token = "0x400506E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetFpOrDefault;

		// Token: 0x0400506F RID: 20591
		[Token(Token = "0x400506F")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetBoolOrDefault;

		// Token: 0x04005070 RID: 20592
		[Token(Token = "0x4005070")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetIntOrDefault;

		// Token: 0x04005071 RID: 20593
		[Token(Token = "0x4005071")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetStringOrDefault;

		// Token: 0x04005072 RID: 20594
		[Token(Token = "0x4005072")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_EnsureFloat;

		// Token: 0x04005073 RID: 20595
		[Token(Token = "0x4005073")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_EnsureBool;

		// Token: 0x04005074 RID: 20596
		[Token(Token = "0x4005074")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EnsureInt;

		// Token: 0x04005075 RID: 20597
		[Token(Token = "0x4005075")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EnsureString;

		// Token: 0x04005076 RID: 20598
		[Token(Token = "0x4005076")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GenerateBlackboardWithPrefix;

		// Token: 0x04005077 RID: 20599
		[Token(Token = "0x4005077")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix1_GenerateBlackboardWithPrefix;

		// Token: 0x04005078 RID: 20600
		[Token(Token = "0x4005078")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_AssignByPrefix;

		// Token: 0x04005079 RID: 20601
		[Token(Token = "0x4005079")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_AssignValueStrByPrefix;

		// Token: 0x0400507A RID: 20602
		[Token(Token = "0x400507A")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_AddBlackboardStrictly;

		// Token: 0x0400507B RID: 20603
		[Token(Token = "0x400507B")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_AddBlackboardBaseOneStrictly;

		// Token: 0x0400507C RID: 20604
		[Token(Token = "0x400507C")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__TryGetNumber;

		// Token: 0x0400507D RID: 20605
		[Token(Token = "0x400507D")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__TryToStripPrefix;

		// Token: 0x02000ED6 RID: 3798
		[Token(Token = "0x2000ED6")]
		[Serializable]
		public struct DataPair
		{
			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x00031638 File Offset: 0x0002F838
			// (set) Token: 0x06006BE6 RID: 27622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D04")]
			[JsonIgnore]
			[Inspect]
			public bool isNumericValue
			{
				[Token(Token = "0x6006BE5")]
				[Address(RVA = "0x19233C0", Offset = "0x1921FC0", VA = "0x1819233C0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6006BE6")]
				[Address(RVA = "0x2008D80", Offset = "0x2007980", VA = "0x182008D80")]
				set
				{
				}
			}

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x06006BE7 RID: 27623 RVA: 0x00031650 File Offset: 0x0002F850
			[Token(Token = "0x17000D05")]
			[JsonIgnore]
			public bool isStringValue
			{
				[Token(Token = "0x6006BE7")]
				[Address(RVA = "0xAC8CE0", Offset = "0xAC78E0", VA = "0x180AC8CE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06006BE8 RID: 27624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BE8")]
			[Address(RVA = "0x2008D40", Offset = "0x2007940", VA = "0x182008D40")]
			public DataPair(string key, float value)
			{
			}

			// Token: 0x06006BE9 RID: 27625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BE9")]
			[Address(RVA = "0x2008D00", Offset = "0x2007900", VA = "0x182008D00")]
			public DataPair(string key, string value)
			{
			}

			// Token: 0x06006BEA RID: 27626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006BEA")]
			[Address(RVA = "0x2008C70", Offset = "0x2007870", VA = "0x182008C70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400507E RID: 20606
			[Token(Token = "0x400507E")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x0400507F RID: 20607
			[Token(Token = "0x400507F")]
			[FieldOffset(Offset = "0x8")]
			[Inspect("isNumericValue")]
			public float value;

			// Token: 0x04005080 RID: 20608
			[Token(Token = "0x4005080")]
			[FieldOffset(Offset = "0x10")]
			[Inspect("isStringValue")]
			public string valueStr;
		}
	}
}
