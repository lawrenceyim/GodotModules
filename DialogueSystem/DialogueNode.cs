namespace DialogueSystem;

public abstract class DialogueNode {
        
}

public class TextNode {
    public int NextNodeId { get; }
    public int TextId { get; }

    public TextNode() {}
    
    public TextNode(int textId, int nextNodeId) {
        TextId = textId;
        NextNodeId = nextNodeId;
    }
}

public class QuestionNode {
    public int QuestionTextId { get; }
    public int[] NextNodesId { get; } 
    public int[] AnswerTextsId { get; }

    public QuestionNode() {
        
    }

    public QuestionNode(int questionTextId, int[] nextNodesId, int[] answerTextsId) {
        questionTextId = questionTextId;
        NextNodesId = nextNodesId;
        AnswerTextsId = answerTextsId;
    }
}