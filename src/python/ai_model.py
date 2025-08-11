from langchain_community.embeddings import HuggingFaceEmbeddings
from huggingface_hub import hf_hub_download
from constants import MODEL_NAME
import sys

def direct_model_import(mypath):
    ckpt_path = hf_hub_download(
            repo_id="Yiwen-ntu/MeshAnything",
            filename="MeshAnything_350m.pth",
        )

def indirect_model_import(mypath):
    encode_kwargs = {'normalize_embeddings': True}
    model_name = "sentence-transformers/msmarco-bert-base-dot-v5"
    hf = HuggingFaceEmbeddings(
        model_name=model_name,
        model_kwargs=model_kwargs,
        encode_kwargs=encode_kwargs
    )


if __name__ == "__main__":
    arguments = sys.argv
    if len(arguments)>1:
        direct_model_import(arguments[1])
        indirect_model_import(arguments[1])
    else:
        print("You need to provide a path to folder with documents to index as command line argument")
 
