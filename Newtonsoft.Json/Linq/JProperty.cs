using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[Preserve]
	public class JProperty : JContainer
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A3")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A4")]
		public string Name
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A5")]
		public new JToken Value
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x4DE3920", Offset = "0x4DE2520", VA = "0x184DE3920")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x4DE3940", Offset = "0x4DE2540", VA = "0x184DE3940")]
			set
			{
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x4DE37D0", Offset = "0x4DE23D0", VA = "0x184DE37D0")]
		public JProperty(JProperty other)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x4DE2D40", Offset = "0x4DE1940", VA = "0x184DE2D40", Slot = "78")]
		internal override JToken GetItem(int index)
		{
			return null;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x4DE34A0", Offset = "0x4DE20A0", VA = "0x184DE34A0", Slot = "79")]
		internal override void SetItem(int index, JToken item)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x4DE33E0", Offset = "0x4DE1FE0", VA = "0x184DE33E0", Slot = "77")]
		internal override bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x4DE3320", Offset = "0x4DE1F20", VA = "0x184DE3320", Slot = "76")]
		internal override void RemoveItemAt(int index)
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x4DE2DB0", Offset = "0x4DE19B0", VA = "0x184DE2DB0", Slot = "74")]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x4DE2DE0", Offset = "0x4DE19E0", VA = "0x184DE2DE0", Slot = "75")]
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x4DE2BB0", Offset = "0x4DE17B0", VA = "0x184DE2BB0", Slot = "82")]
		internal override bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x4DE3220", Offset = "0x4DE1E20", VA = "0x184DE3220", Slot = "86")]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x4DE2A20", Offset = "0x4DE1620", VA = "0x184DE2A20", Slot = "80")]
		internal override void ClearItems()
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x4DE2BD0", Offset = "0x4DE17D0", VA = "0x184DE2BD0", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x4DE2AE0", Offset = "0x4DE16E0", VA = "0x184DE2AE0", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x170001A6")]
		public override JTokenType Type
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "13")]
			[DebuggerStepThrough]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x4DE3870", Offset = "0x4DE2470", VA = "0x184DE3870")]
		internal JProperty(string name)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x4DE36B0", Offset = "0x4DE22B0", VA = "0x184DE36B0")]
		public JProperty(string name, params object[] content)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x4DE36B0", Offset = "0x4DE22B0", VA = "0x184DE36B0")]
		public JProperty(string name, object content)
		{
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x4DE35E0", Offset = "0x4DE21E0", VA = "0x184DE35E0", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x4DE2CA0", Offset = "0x4DE18A0", VA = "0x184DE2CA0", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x4DE2F10", Offset = "0x4DE1B10", VA = "0x184DE2F10")]
		public new static JProperty Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x4DE2F20", Offset = "0x4DE1B20", VA = "0x184DE2F20")]
		public new static JProperty Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x50")]
		private readonly JProperty.JPropertyList _content;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x58")]
		private readonly string _name;

		// Token: 0x020000DD RID: 221
		[Token(Token = "0x20000DD")]
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x4DE2900", Offset = "0x4DE1500", VA = "0x184DE2900", Slot = "16")]
			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000924 RID: 2340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x4DE2900", Offset = "0x4DE1500", VA = "0x184DE2900", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000925 RID: 2341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "11")]
			public void Add(JToken item)
			{
			}

			// Token: 0x06000926 RID: 2342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1DEED20", Offset = "0x1DED920", VA = "0x181DEED20", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06000927 RID: 2343 RVA: 0x000056D0 File Offset: 0x000038D0
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x4DE2870", Offset = "0x4DE1470", VA = "0x184DE2870", Slot = "13")]
			public bool Contains(JToken item)
			{
				return default(bool);
			}

			// Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x4DE2880", Offset = "0x4DE1480", VA = "0x184DE2880", Slot = "14")]
			public void CopyTo(JToken[] array, int arrayIndex)
			{
			}

			// Token: 0x06000929 RID: 2345 RVA: 0x000056E8 File Offset: 0x000038E8
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x4DE29D0", Offset = "0x4DE15D0", VA = "0x184DE29D0", Slot = "15")]
			public bool Remove(JToken item)
			{
				return default(bool);
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x0600092A RID: 2346 RVA: 0x00005700 File Offset: 0x00003900
			[Token(Token = "0x170001A7")]
			public int Count
			{
				[Token(Token = "0x600092A")]
				[Address(RVA = "0x4DE2A00", Offset = "0x4DE1600", VA = "0x184DE2A00", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x0600092B RID: 2347 RVA: 0x00005718 File Offset: 0x00003918
			[Token(Token = "0x170001A8")]
			public bool IsReadOnly
			{
				[Token(Token = "0x600092B")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600092C RID: 2348 RVA: 0x00005730 File Offset: 0x00003930
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x4DE2980", Offset = "0x4DE1580", VA = "0x184DE2980", Slot = "6")]
			public int IndexOf(JToken item)
			{
				return 0;
			}

			// Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x4DE2990", Offset = "0x4DE1590", VA = "0x184DE2990", Slot = "7")]
			public void Insert(int index, JToken item)
			{
			}

			// Token: 0x0600092E RID: 2350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x4DE29B0", Offset = "0x4DE15B0", VA = "0x184DE29B0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x170001A9 RID: 425
			[Token(Token = "0x170001A9")]
			public JToken this[int index]
			{
				[Token(Token = "0x600092F")]
				[Address(RVA = "0x4DE2A10", Offset = "0x4DE1610", VA = "0x184DE2A10", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000930")]
				[Address(RVA = "0x4DE2990", Offset = "0x4DE1590", VA = "0x184DE2990", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public JPropertyList()
			{
			}

			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x10")]
			internal JToken _token;
		}
	}
}
