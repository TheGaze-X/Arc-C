using System;
using Il2CppDummyDll;
using Sirenix.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[SirenixGlobalConfig]
	public class GlobalSerializationConfig : GlobalConfig<GlobalSerializationConfig>
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000003")]
		public ILogger Logger
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4E1D100", Offset = "0x4E1BD00", VA = "0x184E1D100")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public DataFormat EditorSerializationFormat
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return DataFormat.Binary;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public DataFormat BuildSerializationFormat
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return DataFormat.Binary;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public LoggingPolicy LoggingPolicy
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return LoggingPolicy.LogErrors;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public ErrorHandlingPolicy ErrorHandlingPolicy
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return ErrorHandlingPolicy.Resilient;
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4E1CD20", Offset = "0x4E1B920", VA = "0x184E1CD20")]
		private void OnInspectorGUI()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4E1D0C0", Offset = "0x4E1BCC0", VA = "0x184E1D0C0")]
		public GlobalSerializationConfig()
		{
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin's custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nWarning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin's. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!";

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nUsing prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs.";

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I'm about, son. Hide message forever.";

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I'm on my own. Hide message forever.";

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DataFormat[] BuildFormats;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		public bool HideSerializationCautionaryMessage;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x19")]
		public bool HidePrefabCautionaryMessage;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		public bool HideOdinSerializeAttributeWarningMessages;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		public bool HideNonSerializedShowInInspectorWarningMessages;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private DataFormat buildSerializationFormat;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DataFormat editorSerializationFormat;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LoggingPolicy loggingPolicy;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ErrorHandlingPolicy errorHandlingPolicy;
	}
}
