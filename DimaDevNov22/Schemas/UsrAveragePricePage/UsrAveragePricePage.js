define("UsrAveragePricePage", [], function() {
	return {
		entitySchemaName: "",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Button-cbe93355a54e4cf9bba6772816484398",
				"values": {
					"itemType": 5,
					"id": "47553502-18b6-4349-949b-c30605469ea1",
					"style": "red",
					"tag": "Button1",
					"caption": {
						"bindTo": "Resources.Strings.Button1ButtonCaption"
					},
					"click": {
						"bindTo": "onSaveButtonClick"
					},
					"enabled": true
				},
				"parentName": "ProcessActionButtons",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "FLOAT6ff74a6f-98ea-410b-8c74-2b1b73269592",
				"values": {
					"layout": {
						"colSpan": 7,
						"rowSpan": 1,
						"column": 7,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "UsrFloat1",
					"tip": {
						"content": {
							"bindTo": "Resources.Strings.FLOAT6ff74a6f98ea410b8c742b1b73269592Tip"
						}
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_DIFF*/
	};
});
