using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher>
	{
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x1700057F")]
		public bool empty
		{
			[Token(Token = "0x600133C")]
			[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000580")]
		public IEnumerable<KeyValuePair<string, object>> patterns
		{
			[Token(Token = "0x600133D")]
			[Address(RVA = "0x5606A40", Offset = "0x5605640", VA = "0x185606A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x5606090", Offset = "0x5604C90", VA = "0x185606090")]
		public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x5605FF0", Offset = "0x5604BF0", VA = "0x185605FF0")]
		public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x5606120", Offset = "0x5604D20", VA = "0x185606120")]
		public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x56061C0", Offset = "0x5604DC0", VA = "0x1856061C0")]
		public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x5606260", Offset = "0x5604E60", VA = "0x185606260")]
		public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x6001343")]
		public InputDeviceMatcher WithCapability<TValue>(string path, TValue value)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x5606300", Offset = "0x5604F00", VA = "0x185606300")]
		private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x5605860", Offset = "0x5604460", VA = "0x185605860")]
		public float MatchPercentage(InputDeviceDescription deviceDescription)
		{
			return 0f;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x5605D60", Offset = "0x5604960", VA = "0x185605D60")]
		private static bool MatchSingleProperty(object pattern, string value)
		{
			return default(bool);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x56057D0", Offset = "0x56043D0", VA = "0x1856057D0")]
		private static int GetNumPropertiesIn(InputDeviceDescription description)
		{
			return 0;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x5605160", Offset = "0x5603D60", VA = "0x185605160")]
		public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription)
		{
			return default(InputDeviceMatcher);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x5605E60", Offset = "0x5604A60", VA = "0x185605E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x5605010", Offset = "0x5603C10", VA = "0x185605010", Slot = "4")]
		public bool Equals(InputDeviceMatcher other)
		{
			return default(bool);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x5604F70", Offset = "0x5603B70", VA = "0x185604F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x5606AC0", Offset = "0x56056C0", VA = "0x185606AC0")]
		public static bool operator ==(InputDeviceMatcher left, InputDeviceMatcher right)
		{
			return default(bool);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x5606B20", Offset = "0x5605720", VA = "0x185606B20")]
		public static bool operator !=(InputDeviceMatcher left, InputDeviceMatcher right)
		{
			return default(bool);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x3FD8800", Offset = "0x3FD7400", VA = "0x183FD8800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x0")]
		private KeyValuePair<InternedString, object>[] m_Patterns;

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly InternedString kInterfaceKey;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly InternedString kDeviceClassKey;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x20")]
		private static readonly InternedString kManufacturerKey;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0x30")]
		private static readonly InternedString kProductKey;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x40")]
		private static readonly InternedString kVersionKey;

		// Token: 0x02000209 RID: 521
		[Token(Token = "0x2000209")]
		[Serializable]
		internal struct MatcherJson
		{
			// Token: 0x06001350 RID: 4944 RVA: 0x0000A248 File Offset: 0x00008448
			[Token(Token = "0x6001350")]
			[Address(RVA = "0x560AEC0", Offset = "0x5609AC0", VA = "0x18560AEC0")]
			public static InputDeviceMatcher.MatcherJson FromMatcher(InputDeviceMatcher matcher)
			{
				return default(InputDeviceMatcher.MatcherJson);
			}

			// Token: 0x06001351 RID: 4945 RVA: 0x0000A260 File Offset: 0x00008460
			[Token(Token = "0x6001351")]
			[Address(RVA = "0x560B330", Offset = "0x5609F30", VA = "0x18560B330")]
			public InputDeviceMatcher ToMatcher()
			{
				return default(InputDeviceMatcher);
			}

			// Token: 0x04000B70 RID: 2928
			[Token(Token = "0x4000B70")]
			[FieldOffset(Offset = "0x0")]
			public string @interface;

			// Token: 0x04000B71 RID: 2929
			[Token(Token = "0x4000B71")]
			[FieldOffset(Offset = "0x8")]
			public string[] interfaces;

			// Token: 0x04000B72 RID: 2930
			[Token(Token = "0x4000B72")]
			[FieldOffset(Offset = "0x10")]
			public string deviceClass;

			// Token: 0x04000B73 RID: 2931
			[Token(Token = "0x4000B73")]
			[FieldOffset(Offset = "0x18")]
			public string[] deviceClasses;

			// Token: 0x04000B74 RID: 2932
			[Token(Token = "0x4000B74")]
			[FieldOffset(Offset = "0x20")]
			public string manufacturer;

			// Token: 0x04000B75 RID: 2933
			[Token(Token = "0x4000B75")]
			[FieldOffset(Offset = "0x28")]
			public string[] manufacturers;

			// Token: 0x04000B76 RID: 2934
			[Token(Token = "0x4000B76")]
			[FieldOffset(Offset = "0x30")]
			public string product;

			// Token: 0x04000B77 RID: 2935
			[Token(Token = "0x4000B77")]
			[FieldOffset(Offset = "0x38")]
			public string[] products;

			// Token: 0x04000B78 RID: 2936
			[Token(Token = "0x4000B78")]
			[FieldOffset(Offset = "0x40")]
			public string version;

			// Token: 0x04000B79 RID: 2937
			[Token(Token = "0x4000B79")]
			[FieldOffset(Offset = "0x48")]
			public string[] versions;

			// Token: 0x04000B7A RID: 2938
			[Token(Token = "0x4000B7A")]
			[FieldOffset(Offset = "0x50")]
			public InputDeviceMatcher.MatcherJson.Capability[] capabilities;

			// Token: 0x0200020A RID: 522
			[Token(Token = "0x200020A")]
			public struct Capability
			{
				// Token: 0x04000B7B RID: 2939
				[Token(Token = "0x4000B7B")]
				[FieldOffset(Offset = "0x0")]
				public string path;

				// Token: 0x04000B7C RID: 2940
				[Token(Token = "0x4000B7C")]
				[FieldOffset(Offset = "0x8")]
				public string value;
			}
		}
	}
}
