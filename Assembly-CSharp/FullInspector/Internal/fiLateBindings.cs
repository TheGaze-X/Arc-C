using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007C89 RID: 31881
	[Token(Token = "0x2007C89")]
	public static class fiLateBindings
	{
		// Token: 0x0602C896 RID: 182422 RVA: 0x000E0A18 File Offset: 0x000DEC18
		[Token(Token = "0x602C896")]
		[Address(RVA = "0x286BE80", Offset = "0x286AA80", VA = "0x18286BE80")]
		private static bool VerifyBinding(string name, object obj)
		{
			return default(bool);
		}

		// Token: 0x02007C8A RID: 31882
		[Token(Token = "0x2007C8A")]
		public static class _Bindings
		{
			// Token: 0x04040374 RID: 263028
			[Token(Token = "0x4040374")]
			[FieldOffset(Offset = "0x0")]
			public static Func<string, Type, UnityEngine.Object> _AssetDatabase_LoadAssetAtPath;

			// Token: 0x04040375 RID: 263029
			[Token(Token = "0x4040375")]
			[FieldOffset(Offset = "0x8")]
			public static Func<bool> _EditorApplication_isPlaying;

			// Token: 0x04040376 RID: 263030
			[Token(Token = "0x4040376")]
			[FieldOffset(Offset = "0x10")]
			public static Func<bool> _EditorApplication_isCompilingOrChangingToPlayMode;

			// Token: 0x04040377 RID: 263031
			[Token(Token = "0x4040377")]
			[FieldOffset(Offset = "0x18")]
			public static Action<Action> _EditorApplication_InvokeOnEditorThread;

			// Token: 0x04040378 RID: 263032
			[Token(Token = "0x4040378")]
			[FieldOffset(Offset = "0x20")]
			public static Action<Action> _EditorApplication_AddUpdateAction;

			// Token: 0x04040379 RID: 263033
			[Token(Token = "0x4040379")]
			[FieldOffset(Offset = "0x28")]
			public static Action<Action> _EditorApplication_RemUpdateAction;

			// Token: 0x0404037A RID: 263034
			[Token(Token = "0x404037A")]
			[FieldOffset(Offset = "0x30")]
			public static Func<double> _EditorApplication_timeSinceStartup;

			// Token: 0x0404037B RID: 263035
			[Token(Token = "0x404037B")]
			[FieldOffset(Offset = "0x38")]
			public static Func<string, string, string> _EditorPrefs_GetString;

			// Token: 0x0404037C RID: 263036
			[Token(Token = "0x404037C")]
			[FieldOffset(Offset = "0x40")]
			public static Action<string, string> _EditorPrefs_SetString;

			// Token: 0x0404037D RID: 263037
			[Token(Token = "0x404037D")]
			[FieldOffset(Offset = "0x48")]
			public static Action<UnityEngine.Object> _EditorUtility_SetDirty;

			// Token: 0x0404037E RID: 263038
			[Token(Token = "0x404037E")]
			[FieldOffset(Offset = "0x50")]
			public static Func<int, UnityEngine.Object> _EditorUtility_InstanceIdToObject;

			// Token: 0x0404037F RID: 263039
			[Token(Token = "0x404037F")]
			[FieldOffset(Offset = "0x58")]
			public static Func<UnityEngine.Object, bool> _EditorUtility_IsPersistent;

			// Token: 0x04040380 RID: 263040
			[Token(Token = "0x4040380")]
			[FieldOffset(Offset = "0x60")]
			public static Func<string, HideFlags, GameObject> _EditorUtility_CreateGameObjectWithHideFlags;

			// Token: 0x04040381 RID: 263041
			[Token(Token = "0x4040381")]
			[FieldOffset(Offset = "0x68")]
			public static Action _EditorGUI_BeginChangeCheck;

			// Token: 0x04040382 RID: 263042
			[Token(Token = "0x4040382")]
			[FieldOffset(Offset = "0x70")]
			public static Func<bool> _EditorGUI_EndChangeCheck;

			// Token: 0x04040383 RID: 263043
			[Token(Token = "0x4040383")]
			[FieldOffset(Offset = "0x78")]
			public static Action<bool> _EditorGUI_BeginDisabledGroup;

			// Token: 0x04040384 RID: 263044
			[Token(Token = "0x4040384")]
			[FieldOffset(Offset = "0x80")]
			public static Action _EditorGUI_EndDisabledGroup;

			// Token: 0x04040385 RID: 263045
			[Token(Token = "0x4040385")]
			[FieldOffset(Offset = "0x88")]
			public static fiLateBindings._Bindings._EditorGUI_Foldout_Type _EditorGUI_Foldout;

			// Token: 0x04040386 RID: 263046
			[Token(Token = "0x4040386")]
			[FieldOffset(Offset = "0x90")]
			public static Action<Rect, string, CommentType> _EditorGUI_HelpBox;

			// Token: 0x04040387 RID: 263047
			[Token(Token = "0x4040387")]
			[FieldOffset(Offset = "0x98")]
			public static fiLateBindings._Bindings._EditorGUI_Slider_Type<int> _EditorGUI_IntSlider;

			// Token: 0x04040388 RID: 263048
			[Token(Token = "0x4040388")]
			[FieldOffset(Offset = "0xA0")]
			public static fiLateBindings._Bindings._EditorGUI_PopupType _EditorGUI_Popup;

			// Token: 0x04040389 RID: 263049
			[Token(Token = "0x4040389")]
			[FieldOffset(Offset = "0xA8")]
			public static fiLateBindings._Bindings._EditorGUI_Slider_Type<float> _EditorGUI_Slider;

			// Token: 0x0404038A RID: 263050
			[Token(Token = "0x404038A")]
			[FieldOffset(Offset = "0xB0")]
			public static Func<GUIStyle> _EditorStyles_label;

			// Token: 0x0404038B RID: 263051
			[Token(Token = "0x404038B")]
			[FieldOffset(Offset = "0xB8")]
			public static Func<GUIStyle> _EditorStyles_foldout;

			// Token: 0x0404038C RID: 263052
			[Token(Token = "0x404038C")]
			[FieldOffset(Offset = "0xC0")]
			public static Action<bool> _fiEditorGUI_PushHierarchyMode;

			// Token: 0x0404038D RID: 263053
			[Token(Token = "0x404038D")]
			[FieldOffset(Offset = "0xC8")]
			public static Action _fiEditorGUI_PopHierarchyMode;

			// Token: 0x0404038E RID: 263054
			[Token(Token = "0x404038E")]
			[FieldOffset(Offset = "0xD0")]
			public static Func<string, GameObject, GameObject> _PrefabUtility_CreatePrefab;

			// Token: 0x0404038F RID: 263055
			[Token(Token = "0x404038F")]
			[FieldOffset(Offset = "0xD8")]
			public static Func<UnityEngine.Object, bool> _PrefabUtility_IsPrefab;

			// Token: 0x04040390 RID: 263056
			[Token(Token = "0x4040390")]
			[FieldOffset(Offset = "0xE0")]
			public static Func<UnityEngine.Object, bool> _PrefabUtility_IsPrefabInstance;

			// Token: 0x04040391 RID: 263057
			[Token(Token = "0x4040391")]
			[FieldOffset(Offset = "0xE8")]
			public static fiLateBindings._Bindings._PropertyEditor_Edit_Type _PropertyEditor_Edit;

			// Token: 0x04040392 RID: 263058
			[Token(Token = "0x4040392")]
			[FieldOffset(Offset = "0xF0")]
			public static fiLateBindings._Bindings._PropertyEditor_GetElementHeight_Type _PropertyEditor_GetElementHeight;

			// Token: 0x04040393 RID: 263059
			[Token(Token = "0x4040393")]
			[FieldOffset(Offset = "0xF8")]
			public static fiLateBindings._Bindings._PropertyEditor_EditSkipUntilNot_Type _PropertyEditor_EditSkipUntilNot;

			// Token: 0x04040394 RID: 263060
			[Token(Token = "0x4040394")]
			[FieldOffset(Offset = "0x100")]
			public static fiLateBindings._Bindings._PropertyEditor_GetElementHeightSkipUntilNot_Type _PropertyEditor_GetElementHeightSkipUntilNot;

			// Token: 0x04040395 RID: 263061
			[Token(Token = "0x4040395")]
			[FieldOffset(Offset = "0x108")]
			public static Func<UnityEngine.Object> _Selection_activeObject;

			// Token: 0x04040396 RID: 263062
			[Token(Token = "0x4040396")]
			[FieldOffset(Offset = "0x110")]
			public static Func<UnityEngine.Object[]> _Selection_activeSelection;

			// Token: 0x02007C8B RID: 31883
			// (Invoke) Token: 0x0602C898 RID: 182424
			[Token(Token = "0x2007C8B")]
			public delegate bool _EditorGUI_Foldout_Type(Rect rect, bool status, GUIContent label, bool toggleOnLabelClick, GUIStyle style);

			// Token: 0x02007C8C RID: 31884
			// (Invoke) Token: 0x0602C89C RID: 182428
			[Token(Token = "0x2007C8C")]
			public delegate T _EditorGUI_Slider_Type<T>(Rect position, GUIContent label, T value, T leftValue, T rightValue);

			// Token: 0x02007C8D RID: 31885
			// (Invoke) Token: 0x0602C8A0 RID: 182432
			[Token(Token = "0x2007C8D")]
			public delegate int _EditorGUI_PopupType(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions);

			// Token: 0x02007C8E RID: 31886
			// (Invoke) Token: 0x0602C8A4 RID: 182436
			[Token(Token = "0x2007C8E")]
			public delegate object _PropertyEditor_Edit_Type(Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata, Type[] skippedEditors);

			// Token: 0x02007C8F RID: 31887
			// (Invoke) Token: 0x0602C8A8 RID: 182440
			[Token(Token = "0x2007C8F")]
			public delegate float _PropertyEditor_GetElementHeight_Type(Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata, Type[] skippedEditors);

			// Token: 0x02007C90 RID: 31888
			// (Invoke) Token: 0x0602C8AC RID: 182444
			[Token(Token = "0x2007C90")]
			public delegate object _PropertyEditor_EditSkipUntilNot_Type(Type[] skipUntilNot, Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata);

			// Token: 0x02007C91 RID: 31889
			// (Invoke) Token: 0x0602C8B0 RID: 182448
			[Token(Token = "0x2007C91")]
			public delegate float _PropertyEditor_GetElementHeightSkipUntilNot_Type(Type[] skipUntilNot, Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata);
		}

		// Token: 0x02007C92 RID: 31890
		[Token(Token = "0x2007C92")]
		public static class AssetDatabase
		{
			// Token: 0x0602C8B3 RID: 182451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C8B3")]
			[Address(RVA = "0x2853AC0", Offset = "0x28526C0", VA = "0x182853AC0")]
			public static UnityEngine.Object LoadAssetAtPath(string path, Type type)
			{
				return null;
			}
		}

		// Token: 0x02007C93 RID: 31891
		[Token(Token = "0x2007C93")]
		public static class EditorApplication
		{
			// Token: 0x17006846 RID: 26694
			// (get) Token: 0x0602C8B4 RID: 182452 RVA: 0x000E0A30 File Offset: 0x000DEC30
			[Token(Token = "0x17006846")]
			public static bool isPlaying
			{
				[Token(Token = "0x602C8B4")]
				[Address(RVA = "0x2855FA0", Offset = "0x2854BA0", VA = "0x182855FA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17006847 RID: 26695
			// (get) Token: 0x0602C8B5 RID: 182453 RVA: 0x000E0A48 File Offset: 0x000DEC48
			[Token(Token = "0x17006847")]
			public static bool isCompilingOrChangingToPlayMode
			{
				[Token(Token = "0x602C8B5")]
				[Address(RVA = "0x2855E90", Offset = "0x2854A90", VA = "0x182855E90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17006848 RID: 26696
			// (get) Token: 0x0602C8B6 RID: 182454 RVA: 0x000E0A60 File Offset: 0x000DEC60
			[Token(Token = "0x17006848")]
			public static double timeSinceStartup
			{
				[Token(Token = "0x602C8B6")]
				[Address(RVA = "0x28560B0", Offset = "0x2854CB0", VA = "0x1828560B0")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x0602C8B7 RID: 182455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8B7")]
			[Address(RVA = "0x2855C50", Offset = "0x2854850", VA = "0x182855C50")]
			public static void InvokeOnEditorThread(Action func)
			{
			}

			// Token: 0x0602C8B8 RID: 182456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8B8")]
			[Address(RVA = "0x2855B30", Offset = "0x2854730", VA = "0x182855B30")]
			public static void AddUpdateFunc(Action func)
			{
			}

			// Token: 0x0602C8B9 RID: 182457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8B9")]
			[Address(RVA = "0x2855D70", Offset = "0x2854970", VA = "0x182855D70")]
			public static void RemUpdateFunc(Action func)
			{
			}
		}

		// Token: 0x02007C94 RID: 31892
		[Token(Token = "0x2007C94")]
		public static class EditorPrefs
		{
			// Token: 0x0602C8BA RID: 182458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C8BA")]
			[Address(RVA = "0x2856D50", Offset = "0x2855950", VA = "0x182856D50")]
			public static string GetString(string key, string defaultValue)
			{
				return null;
			}

			// Token: 0x0602C8BB RID: 182459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8BB")]
			[Address(RVA = "0x2856E80", Offset = "0x2855A80", VA = "0x182856E80")]
			public static void SetString(string key, string value)
			{
			}
		}

		// Token: 0x02007C95 RID: 31893
		[Token(Token = "0x2007C95")]
		public static class EditorUtility
		{
			// Token: 0x0602C8BC RID: 182460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8BC")]
			[Address(RVA = "0x28575E0", Offset = "0x28561E0", VA = "0x1828575E0")]
			public static void SetDirty(UnityEngine.Object unityObject)
			{
			}

			// Token: 0x0602C8BD RID: 182461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C8BD")]
			[Address(RVA = "0x2857390", Offset = "0x2855F90", VA = "0x182857390")]
			public static UnityEngine.Object InstanceIDToObject(int instanceId)
			{
				return null;
			}

			// Token: 0x0602C8BE RID: 182462 RVA: 0x000E0A78 File Offset: 0x000DEC78
			[Token(Token = "0x602C8BE")]
			[Address(RVA = "0x28574B0", Offset = "0x28560B0", VA = "0x1828574B0")]
			public static bool IsPersistent(UnityEngine.Object unityObject)
			{
				return default(bool);
			}

			// Token: 0x0602C8BF RID: 182463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C8BF")]
			[Address(RVA = "0x2857220", Offset = "0x2855E20", VA = "0x182857220")]
			public static GameObject CreateGameObjectWithHideFlags(string name, HideFlags hideFlags)
			{
				return null;
			}
		}

		// Token: 0x02007C96 RID: 31894
		[Token(Token = "0x2007C96")]
		public static class EditorGUI
		{
			// Token: 0x0602C8C0 RID: 182464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8C0")]
			[Address(RVA = "0x2856210", Offset = "0x2854E10", VA = "0x182856210")]
			public static void BeginChangeCheck()
			{
			}

			// Token: 0x0602C8C1 RID: 182465 RVA: 0x000E0A90 File Offset: 0x000DEC90
			[Token(Token = "0x602C8C1")]
			[Address(RVA = "0x2856440", Offset = "0x2855040", VA = "0x182856440")]
			public static bool EndChangeCheck()
			{
				return default(bool);
			}

			// Token: 0x0602C8C2 RID: 182466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8C2")]
			[Address(RVA = "0x2856320", Offset = "0x2854F20", VA = "0x182856320")]
			public static void BeginDisabledGroup(bool disabled)
			{
			}

			// Token: 0x0602C8C3 RID: 182467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8C3")]
			[Address(RVA = "0x2856550", Offset = "0x2855150", VA = "0x182856550")]
			public static void EndDisabledGroup()
			{
			}

			// Token: 0x0602C8C4 RID: 182468 RVA: 0x000E0AA8 File Offset: 0x000DECA8
			[Token(Token = "0x602C8C4")]
			[Address(RVA = "0x2856660", Offset = "0x2855260", VA = "0x182856660")]
			public static bool Foldout(Rect rect, bool state, GUIContent label, bool toggleOnLabelClick, GUIStyle style)
			{
				return default(bool);
			}

			// Token: 0x0602C8C5 RID: 182469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8C5")]
			[Address(RVA = "0x28567D0", Offset = "0x28553D0", VA = "0x1828567D0")]
			public static void HelpBox(Rect rect, string message, CommentType commentType)
			{
			}

			// Token: 0x0602C8C6 RID: 182470 RVA: 0x000E0AC0 File Offset: 0x000DECC0
			[Token(Token = "0x602C8C6")]
			[Address(RVA = "0x2856920", Offset = "0x2855520", VA = "0x182856920")]
			public static int IntSlider(Rect position, GUIContent label, int value, int leftValue, int rightValue)
			{
				return 0;
			}

			// Token: 0x0602C8C7 RID: 182471 RVA: 0x000E0AD8 File Offset: 0x000DECD8
			[Token(Token = "0x602C8C7")]
			[Address(RVA = "0x2856A80", Offset = "0x2855680", VA = "0x182856A80")]
			public static int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions)
			{
				return 0;
			}

			// Token: 0x0602C8C8 RID: 182472 RVA: 0x000E0AF0 File Offset: 0x000DECF0
			[Token(Token = "0x602C8C8")]
			[Address(RVA = "0x2856BE0", Offset = "0x28557E0", VA = "0x182856BE0")]
			public static float Slider(Rect position, GUIContent label, float value, float leftValue, float rightValue)
			{
				return 0f;
			}
		}

		// Token: 0x02007C97 RID: 31895
		[Token(Token = "0x2007C97")]
		public static class EditorGUIUtility
		{
			// Token: 0x04040397 RID: 263063
			[Token(Token = "0x4040397")]
			[FieldOffset(Offset = "0x0")]
			public static float standardVerticalSpacing;

			// Token: 0x04040398 RID: 263064
			[Token(Token = "0x4040398")]
			[FieldOffset(Offset = "0x4")]
			public static float singleLineHeight;
		}

		// Token: 0x02007C98 RID: 31896
		[Token(Token = "0x2007C98")]
		public static class EditorStyles
		{
			// Token: 0x17006849 RID: 26697
			// (get) Token: 0x0602C8CA RID: 182474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006849")]
			public static GUIStyle label
			{
				[Token(Token = "0x602C8CA")]
				[Address(RVA = "0x28570E0", Offset = "0x2855CE0", VA = "0x1828570E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700684A RID: 26698
			// (get) Token: 0x0602C8CB RID: 182475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700684A")]
			public static GUIStyle foldout
			{
				[Token(Token = "0x602C8CB")]
				[Address(RVA = "0x2856FA0", Offset = "0x2855BA0", VA = "0x182856FA0")]
				get
				{
					return null;
				}
			}
		}

		// Token: 0x02007C99 RID: 31897
		[Token(Token = "0x2007C99")]
		public static class fiEditorGUI
		{
			// Token: 0x0602C8CC RID: 182476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8CC")]
			[Address(RVA = "0x2867FC0", Offset = "0x2866BC0", VA = "0x182867FC0")]
			public static void PushHierarchyMode(bool state)
			{
			}

			// Token: 0x0602C8CD RID: 182477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C8CD")]
			[Address(RVA = "0x2867EB0", Offset = "0x2866AB0", VA = "0x182867EB0")]
			public static void PopHierarchyMode()
			{
			}
		}

		// Token: 0x02007C9A RID: 31898
		[Token(Token = "0x2007C9A")]
		public static class PrefabUtility
		{
			// Token: 0x0602C8CE RID: 182478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C8CE")]
			[Address(RVA = "0x2862340", Offset = "0x2860F40", VA = "0x182862340")]
			public static GameObject CreatePrefab(string path, GameObject template)
			{
				return null;
			}

			// Token: 0x0602C8CF RID: 182479 RVA: 0x000E0B08 File Offset: 0x000DED08
			[Token(Token = "0x602C8CF")]
			[Address(RVA = "0x2862470", Offset = "0x2861070", VA = "0x182862470")]
			public static bool IsPrefabInstance(UnityEngine.Object unityObject)
			{
				return default(bool);
			}

			// Token: 0x0602C8D0 RID: 182480 RVA: 0x000E0B20 File Offset: 0x000DED20
			[Token(Token = "0x602C8D0")]
			[Address(RVA = "0x28625B0", Offset = "0x28611B0", VA = "0x1828625B0")]
			public static bool IsPrefab(UnityEngine.Object unityObject)
			{
				return default(bool);
			}
		}

		// Token: 0x02007C9B RID: 31899
		[Token(Token = "0x2007C9B")]
		public static class PropertyEditor
		{
			// Token: 0x0602C8D1 RID: 182481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C8D1")]
			[Address(RVA = "0x2862870", Offset = "0x2861470", VA = "0x182862870")]
			public static object Edit(Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata, params Type[] skippedEditors)
			{
				return null;
			}

			// Token: 0x0602C8D2 RID: 182482 RVA: 0x000E0B38 File Offset: 0x000DED38
			[Token(Token = "0x602C8D2")]
			[Address(RVA = "0x2862B70", Offset = "0x2861770", VA = "0x182862B70")]
			public static float GetElementHeight(Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata, params Type[] skippedEditors)
			{
				return 0f;
			}

			// Token: 0x0602C8D3 RID: 182483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C8D3")]
			[Address(RVA = "0x28626E0", Offset = "0x28612E0", VA = "0x1828626E0")]
			public static object EditSkipUntilNot(Type[] skipUntilNot, Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata)
			{
				return null;
			}

			// Token: 0x0602C8D4 RID: 182484 RVA: 0x000E0B50 File Offset: 0x000DED50
			[Token(Token = "0x602C8D4")]
			[Address(RVA = "0x2862A00", Offset = "0x2861600", VA = "0x182862A00")]
			public static float GetElementHeightSkipUntilNot(Type[] skipUntilNot, Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata)
			{
				return 0f;
			}
		}

		// Token: 0x02007C9C RID: 31900
		[Token(Token = "0x2007C9C")]
		public static class Selection
		{
			// Token: 0x1700684B RID: 26699
			// (get) Token: 0x0602C8D5 RID: 182485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700684B")]
			public static UnityEngine.Object activeObject
			{
				[Token(Token = "0x602C8D5")]
				[Address(RVA = "0x2863850", Offset = "0x2862450", VA = "0x182863850")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700684C RID: 26700
			// (get) Token: 0x0602C8D6 RID: 182486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700684C")]
			public static UnityEngine.Object[] activeSelection
			{
				[Token(Token = "0x602C8D6")]
				[Address(RVA = "0x2863970", Offset = "0x2862570", VA = "0x182863970")]
				get
				{
					return null;
				}
			}
		}
	}
}
