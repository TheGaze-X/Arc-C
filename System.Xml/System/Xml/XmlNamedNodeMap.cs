using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class XmlNamedNodeMap : IEnumerable
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal XmlNamedNodeMap(XmlNode parent)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x4FD3900", Offset = "0x4FD2500", VA = "0x184FD3900", Slot = "5")]
		public virtual XmlNode GetNamedItem(string name)
		{
			return null;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x4FD4080", Offset = "0x4FD2C80", VA = "0x184FD4080", Slot = "6")]
		public virtual XmlNode SetNamedItem(XmlNode node)
		{
			return null;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x17000171")]
		public virtual int Count
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x4FD4310", Offset = "0x4FD2F10", VA = "0x184FD4310", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x4FD38F0", Offset = "0x4FD24F0", VA = "0x184FD38F0", Slot = "8")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x4FD35F0", Offset = "0x4FD21F0", VA = "0x184FD35F0")]
		internal int FindNodeOffset(string name)
		{
			return 0;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x4FD3760", Offset = "0x4FD2360", VA = "0x184FD3760")]
		internal int FindNodeOffset(string localName, string namespaceURI)
		{
			return 0;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x4FD3310", Offset = "0x4FD1F10", VA = "0x184FD3310", Slot = "9")]
		internal virtual XmlNode AddNode(XmlNode node)
		{
			return null;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x4FD3220", Offset = "0x4FD1E20", VA = "0x184FD3220", Slot = "10")]
		internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			return null;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x4FD3DE0", Offset = "0x4FD29E0", VA = "0x184FD3DE0", Slot = "11")]
		internal virtual XmlNode RemoveNodeAt(int i)
		{
			return null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x4FD3FF0", Offset = "0x4FD2BF0", VA = "0x184FD3FF0")]
		internal XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			return null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x4FD3B00", Offset = "0x4FD2700", VA = "0x184FD3B00", Slot = "12")]
		internal virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			return null;
		}

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x10")]
		internal XmlNode parent;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x18")]
		internal XmlNamedNodeMap.SmallXmlNodeList nodes;

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		internal struct SmallXmlNodeList
		{
			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060005B8 RID: 1464 RVA: 0x000036D8 File Offset: 0x000018D8
			[Token(Token = "0x17000172")]
			public int Count
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x4FCA0D0", Offset = "0x4FC8CD0", VA = "0x184FCA0D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000173 RID: 371
			[Token(Token = "0x17000173")]
			public object this[int index]
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x4FCA1B0", Offset = "0x4FC8DB0", VA = "0x184FCA1B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060005BA RID: 1466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x4FC99C0", Offset = "0x4FC85C0", VA = "0x184FC99C0")]
			public void Add(object value)
			{
			}

			// Token: 0x060005BB RID: 1467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x4FC9F40", Offset = "0x4FC8B40", VA = "0x184FC9F40")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x060005BC RID: 1468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x4FC9D00", Offset = "0x4FC8900", VA = "0x184FC9D00")]
			public void Insert(int index, object value)
			{
			}

			// Token: 0x060005BD RID: 1469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x4FC9B90", Offset = "0x4FC8790", VA = "0x184FC9B90")]
			public IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x0")]
			private object field;

			// Token: 0x02000078 RID: 120
			[Token(Token = "0x2000078")]
			private class SingleObjectEnumerator : IEnumerator
			{
				// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x4A5F040", Offset = "0x4A5DC40", VA = "0x184A5F040")]
				public SingleObjectEnumerator(object value)
				{
				}

				// Token: 0x17000174 RID: 372
				// (get) Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000174")]
				public object Current
				{
					[Token(Token = "0x60005BF")]
					[Address(RVA = "0x4FC9960", Offset = "0x4FC8560", VA = "0x184FC9960", Slot = "5")]
					get
					{
						return null;
					}
				}

				// Token: 0x060005C0 RID: 1472 RVA: 0x000036F0 File Offset: 0x000018F0
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x4FC9940", Offset = "0x4FC8540", VA = "0x184FC9940", Slot = "4")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x060005C1 RID: 1473 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "6")]
				public void Reset()
				{
				}

				// Token: 0x040002F0 RID: 752
				[Token(Token = "0x40002F0")]
				[FieldOffset(Offset = "0x10")]
				private object loneValue;

				// Token: 0x040002F1 RID: 753
				[Token(Token = "0x40002F1")]
				[FieldOffset(Offset = "0x18")]
				private int position;
			}
		}
	}
}
