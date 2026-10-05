using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[Preserve]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, System.ComponentModel.INotifyPropertyChanging
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000177")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "70")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060007AF RID: 1967 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x4DC1740", Offset = "0x4DC0340", VA = "0x184DC1740", Slot = "103")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x4DC1A00", Offset = "0x4DC0600", VA = "0x184DC1A00", Slot = "104")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060007B1 RID: 1969 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060007B2 RID: 1970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x4DC17E0", Offset = "0x4DC03E0", VA = "0x184DC17E0", Slot = "117")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x4DC1AA0", Offset = "0x4DC06A0", VA = "0x184DC1AA0", Slot = "118")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x4DC1690", Offset = "0x4DC0290", VA = "0x184DC1690")]
		public JObject()
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x4DC1600", Offset = "0x4DC0200", VA = "0x184DC1600")]
		public JObject(JObject other)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x4DC1520", Offset = "0x4DC0120", VA = "0x184DC1520")]
		public JObject(params object[] content)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x4DC1520", Offset = "0x4DC0120", VA = "0x184DC1520")]
		public JObject(object content)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x4DBEEE0", Offset = "0x4DBDAE0", VA = "0x184DBEEE0", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x4DBF470", Offset = "0x4DBE070", VA = "0x184DBF470", Slot = "74")]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x4DBF560", Offset = "0x4DBE160", VA = "0x184DBF560", Slot = "75")]
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x4DC1070", Offset = "0x4DBFC70", VA = "0x184DC1070", Slot = "84")]
		internal override void ValidateToken(JToken o, JToken existing)
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x4DBF970", Offset = "0x4DBE570", VA = "0x184DBF970", Slot = "86")]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x4DBF5E0", Offset = "0x4DBE1E0", VA = "0x184DBF5E0")]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x4DBF6E0", Offset = "0x4DBE2E0", VA = "0x184DBF6E0")]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x4DBEE20", Offset = "0x4DBDA20", VA = "0x184DBEE20", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x17000178")]
		public override JTokenType Type
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "13")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x4DBFFD0", Offset = "0x4DBEBD0", VA = "0x184DBFFD0")]
		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x4DC0190", Offset = "0x4DBED90", VA = "0x184DC0190")]
		public JProperty Property(string name)
		{
			return null;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x4DC0010", Offset = "0x4DBEC10", VA = "0x184DC0010")]
		public JEnumerable<JToken> PropertyValues()
		{
			return default(JEnumerable<JToken>);
		}

		// Token: 0x17000179 RID: 377
		[Token(Token = "0x17000179")]
		public override JToken this[object key]
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x4DC1880", Offset = "0x4DC0480", VA = "0x184DC1880", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x4DC1C70", Offset = "0x4DC0870", VA = "0x184DC1C70", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		[Token(Token = "0x1700017A")]
		public JToken this[string propertyName]
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x4DC1990", Offset = "0x4DC0590", VA = "0x184DC1990", Slot = "87")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x4DC1B40", Offset = "0x4DC0740", VA = "0x184DC1B40", Slot = "88")]
			set
			{
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4DBF730", Offset = "0x4DBE330", VA = "0x184DBF730")]
		public new static JObject Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x4DBF740", Offset = "0x4DBE340", VA = "0x184DBF740")]
		public new static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x4DBFDD0", Offset = "0x4DBE9D0", VA = "0x184DBFDD0")]
		public new static JObject Parse(string json)
		{
			return null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x4DBFDE0", Offset = "0x4DBE9E0", VA = "0x184DBFDE0")]
		public new static JObject Parse(string json, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x4DBEF90", Offset = "0x4DBDB90", VA = "0x184DBEF90")]
		public new static JObject FromObject(object o)
		{
			return null;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x4DBEFC0", Offset = "0x4DBDBC0", VA = "0x184DBEFC0")]
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x4DC13D0", Offset = "0x4DBFFD0", VA = "0x184DC13D0", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x4DBF460", Offset = "0x4DBE060", VA = "0x184DBF460")]
		public JToken GetValue(string propertyName)
		{
			return null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x4DBF210", Offset = "0x4DBDE10", VA = "0x184DBF210")]
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			return null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x4DC0FF0", Offset = "0x4DBFBF0", VA = "0x184DC0FF0")]
		public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value)
		{
			return default(bool);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x4DBED80", Offset = "0x4DBD980", VA = "0x184DBED80", Slot = "92")]
		public void Add(string propertyName, JToken value)
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x4DC0A20", Offset = "0x4DBF620", VA = "0x184DC0A20", Slot = "91")]
		private bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		private ICollection<string> Keys
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x4DC0AE0", Offset = "0x4DBF6E0", VA = "0x184DC0AE0", Slot = "89")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x4DC02C0", Offset = "0x4DBEEC0", VA = "0x184DC02C0", Slot = "93")]
		public bool Remove(string propertyName)
		{
			return default(bool);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x4DC1020", Offset = "0x4DBFC20", VA = "0x184DC1020", Slot = "94")]
		public bool TryGetValue(string propertyName, out JToken value)
		{
			return default(bool);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		private ICollection<JToken> Values
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x4DC0B40", Offset = "0x4DBF740", VA = "0x184DC0B40", Slot = "90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x4DC0370", Offset = "0x4DBEF70", VA = "0x184DC0370", Slot = "97")]
		private void Add(KeyValuePair<string, JToken> item)
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x4DB81F0", Offset = "0x4DB6DF0", VA = "0x184DB81F0", Slot = "98")]
		private void Clear()
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x4DC0420", Offset = "0x4DBF020", VA = "0x184DC0420", Slot = "99")]
		private bool Contains(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x4DC04A0", Offset = "0x4DBF0A0", VA = "0x184DC04A0", Slot = "100")]
		private void CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x1700017D")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x4DC0870", Offset = "0x4DBF470", VA = "0x184DC0870", Slot = "101")]
		private bool Remove(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x4DB87B0", Offset = "0x4DB73B0", VA = "0x184DB87B0", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x4DBF190", Offset = "0x4DBDD90", VA = "0x184DBF190", Slot = "102")]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x4DBFCB0", Offset = "0x4DBE8B0", VA = "0x184DBFCB0", Slot = "119")]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x4DBFD40", Offset = "0x4DBE940", VA = "0x184DBFD40", Slot = "120")]
		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x4DC0F20", Offset = "0x4DBFB20", VA = "0x184DC0F20", Slot = "114")]
		private PropertyDescriptorCollection GetProperties()
		{
			return null;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x4DC0CD0", Offset = "0x4DBF8D0", VA = "0x184DC0CD0", Slot = "115")]
		private PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x4DC0B90", Offset = "0x4DBF790", VA = "0x184DC0B90", Slot = "105")]
		private AttributeCollection GetAttributes()
		{
			return null;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "106")]
		private string GetClassName()
		{
			return null;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "107")]
		private string GetComponentName()
		{
			return null;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x4DC0BE0", Offset = "0x4DBF7E0", VA = "0x184DC0BE0", Slot = "108")]
		private TypeConverter GetConverter()
		{
			return null;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "109")]
		private EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "110")]
		private PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "111")]
		private object GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x4DC0C30", Offset = "0x4DBF830", VA = "0x184DC0C30", Slot = "113")]
		private EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x4DC0C80", Offset = "0x4DBF880", VA = "0x184DC0C80", Slot = "112")]
		private EventDescriptorCollection GetEvents()
		{
			return null;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "116")]
		private object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x50")]
		private readonly JPropertyKeyedCollection _properties;
	}
}
